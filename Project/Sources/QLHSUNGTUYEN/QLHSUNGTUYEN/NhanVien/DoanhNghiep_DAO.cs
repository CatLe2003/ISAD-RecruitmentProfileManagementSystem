using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSUNGTUYEN.NhanVien.DAL
{
    internal class DoanhNghiep_DAO
    {
        private string strConn = @"Data Source=LAPTOP-CL7N23GM\SQLEXPRESS;Initial Catalog=QLHSUNGTUYEN;Integrated Security=True";

        public DoanhNghiep_DAO()
        {

        }
        public int DocThongTinDN(int MaDN)
        {
            int count = 0;
            try
            {
                // Connect to the database
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    //Check if MaDN exists in table DOANHNGHIEP 
                    string query = "SELECT COUNT(*) FROM DOANHNGHIEP WHERE MaDN = @MaDN";
                   
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaDN", MaDN);

                    // Execute the command and read the data
                    count = (int)cmd.ExecuteScalar(); //return single value (number of rows)
                    return count;
                }
                
            }
             
            catch (Exception ex)
            {
                MessageBox.Show("Error in DoanhNghiep_DAO.DocThongTinDN: " + ex.Message);
                count = -1; 
            }
            return count;
           
        }

    }
}
