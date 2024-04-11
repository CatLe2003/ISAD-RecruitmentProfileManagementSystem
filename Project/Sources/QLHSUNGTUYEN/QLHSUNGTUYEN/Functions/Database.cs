using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSUNGTUYEN
{
    public class Database
    {
        private string strCon = @"Data Source=LAPTOP-MA9ME0JB; Initial Catalog=QLHSUngTuyen;Integrated Security=True;";
        private SqlConnection conn;
        /*private string sql;*/
        private DataTable dtable;
        private SqlCommand cmd;
        public Database()
        {
            try
            {
                conn = new SqlConnection(strCon);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connected failed: " + ex.Message);
            }
        }

        public DataTable SelectData(string sql, List<CustomParameter> lstPara)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd = new SqlCommand(sql, conn);
                if (lstPara != null)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (var p in lstPara) // gán các tham số cho cmd
                    {
                        Console.WriteLine(p.value);
                        cmd.Parameters.AddWithValue(p.key, p.value);
                    }
                }
                dtable = new DataTable();
                dtable.Load(cmd.ExecuteReader());
                return dtable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }

        public DataRow Select(string sql, List<CustomParameter> lstPara)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd = new SqlCommand(sql, conn);
                if (lstPara != null)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (var p in lstPara) // gán các tham số cho cmd
                    {
                        Console.WriteLine(p.value);
                        cmd.Parameters.AddWithValue(p.key, p.value);
                    }
                }
                dtable = new DataTable();
                dtable.Load(cmd.ExecuteReader());
                return dtable.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load thông tin chi tiết: " + ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }

        public int ExeCute(string sql, List<CustomParameter> lstPara)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd = new SqlCommand(sql, conn); // thực thi câu lệnh sql
                if (lstPara != null)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (var p in lstPara) // gán các tham số cho cmd
                    {
                        Console.WriteLine(p.value);
                        cmd.Parameters.AddWithValue(p.key,p.value);
                    }
                }
                Console.WriteLine(sql);
                var res = cmd.ExecuteNonQuery(); // lấy kết quả truy vấn
                return (int)res;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi câu lệnh: " + ex.Message);
                return -100;
            }
            finally { conn.Close(); }
        }
    }
}
