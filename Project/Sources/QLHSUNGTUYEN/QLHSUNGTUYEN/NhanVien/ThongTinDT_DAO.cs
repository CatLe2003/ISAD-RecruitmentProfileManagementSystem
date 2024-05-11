using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSUNGTUYEN.NhanVien.DAL
{
    internal class ThongTinDT_DAO
    {
        public ThongTinDT_DAO()
        {
        }

        private string strConn = @"Data Source=LAPTOP-CL7N23GM\SQLEXPRESS; Initial Catalog=QLHSUngTuyen;Integrated Security=True;";


        public int DocTTDT(int MaDT)
        {
            int result = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(strConn))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM THONGTINDANGTUYEN WHERE MaDT = @MaDT";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaDT", MaDT);

                        // Execute the query
                        object queryResult = command.ExecuteScalar();

                        // Check if the result is not null and convert it to int
                        if (queryResult != null && queryResult != DBNull.Value)
                        {
                            result = Convert.ToInt32(queryResult);
                        }
                    }
                }

                if (result == 1) // If MaDT exists in table THONGTINDANGTUYEN
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in ThongTinDT_DAO.DocTTDT: " + ex.Message);
            }

            return result;
        }

        //Kiem tra MaDT tuong ung voi MaDN
        public int DocTTMaDTCuaDN(int MaDT, int MaDN)
        {
            int result = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(strConn))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM THONGTINDANGTUYEN WHERE MaDT = @MaDT AND MaDN = @MaDN";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaDT", MaDT);
                        command.Parameters.AddWithValue("@MaDN", MaDN);

                        // Execute the query
                        object queryResult = command.ExecuteScalar();

                        // Check if the result is not null and convert it to int
                        if (queryResult != null && queryResult != DBNull.Value)
                        {
                            result = Convert.ToInt32(queryResult);
                        }
                    }
                }

                if (result >= 1) //If exists 
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in ThongTinDT_DAO.DocTTMaDTCuaDN: " + ex.Message);
            }

            return result;
        }

    }
}
