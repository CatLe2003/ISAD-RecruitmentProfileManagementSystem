using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QLHSUNGTUYEN.NhanVien.BLL;
using QLHSUNGTUYEN.NhanVien.Forms;
using System.Windows.Forms;

namespace QLHSUNGTUYEN.NhanVien.DAL
{
    internal class HopDong_DAO
    {
        private string strConn = @"Data Source=LAPTOP-CL7N23GM\SQLEXPRESS;Initial Catalog=QLHSUNGTUYEN;Integrated Security=True";
       
        public HopDong_DAO()
        {

        }
        public int TimKiemHDGoc(int MaDN)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    string query = "SELECT DISTINCT MaHDong FROM HOPDONG WHERE MaDN = @MaDN AND PhuLuc IS NULL";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaDN", MaDN);

                    int MaHDGoc = (int)cmd.ExecuteScalar();

                    return MaHDGoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in HopDong_DAO.TimKiemHDGoc: " + ex.Message);
                throw; 
            }
        }

        public int DocThongTinDNTrongHD(int MaDN)
        {
            DoanhNghiep_DAO doanhNghiep_DAO = new DoanhNghiep_DAO();
            int result = doanhNghiep_DAO.DocThongTinDN(MaDN);
            try {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    if (result == 1)
                    {
                        //Check if MaDN exists in table HOPDONG 
                        string query1 = "SELECT COUNT(*) FROM HOPDONG WHERE MaDN = @MaDN";
                        SqlCommand cmd1 = new SqlCommand(query1, conn);
                        cmd1.Parameters.AddWithValue("@MaDN", MaDN);

                        int count1 = (int)cmd1.ExecuteScalar();
                        if (count1 > 0)
                        {
                            result = 2; // MaDN exists in HOPDONG
                        }
                        else
                        {
                            result = 1; // MaDN does not exist in HOPDONG
                        }
                    }
                    else if (result == 0)
                    {
                        result = 0; // MaDN does not exist in DOANHNGHIEP
                    } else
                    {
                           result = -1; // Error
                    }
                    return result;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in HopDong_DAO.DocThongTinDNTrongHD: " + ex.Message);
                throw;
            }
           
        }
        public bool ThemHopDong(int MaNV, int MaDN, HopDong hopDong)
        {
            try
            {
                bool result = false;

                // Connect to the database
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    // Execute the stored procedure sp_GhiNhanHopDong
                    SqlCommand cmd = new SqlCommand("sp_LapHopDong", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters to the command
                    //cmd.Parameters.AddWithValue("@MaHD", lapHopDong.MaHD);
                    //cmd.Parameters.AddWithValue("@ID", lapHopDong.ID);
                    cmd.Parameters.AddWithValue("@MaNV", MaNV);
                    cmd.Parameters.AddWithValue("@MaDN", MaDN);
                    cmd.Parameters.AddWithValue("@NgKy", hopDong.NgKy);
                    cmd.Parameters.AddWithValue("@NgHetHan", hopDong.NgHetHan);
                    cmd.Parameters.AddWithValue("@Noidung", hopDong.NoiDung);
                    if (hopDong.PhuLuc != null)
                    {
                        cmd.Parameters.AddWithValue("@PhuLuc", hopDong.PhuLuc);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@PhuLuc", DBNull.Value); // Or set it to DBNull.Value
                    }
                    cmd.Parameters.AddWithValue("@SoDotTT", hopDong.SoDotTT);
                    cmd.Parameters.AddWithValue("@SoTienTT", hopDong.SoTienTT);
                    cmd.Parameters.AddWithValue("@TinhTrangKyDuyet", hopDong.TinhTrangKyDuyet);
                    cmd.Parameters.AddWithValue("@Uudai", hopDong.UuDai);

                    // Execute the command
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Check if the operation was successful
                    if (rowsAffected == 1)
                        result = true;
                }

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in HopDong_DAO.ThemHopDong: " + ex.Message);
                return false; // Handle errors more gracefully
            }
        }   
    }
}
