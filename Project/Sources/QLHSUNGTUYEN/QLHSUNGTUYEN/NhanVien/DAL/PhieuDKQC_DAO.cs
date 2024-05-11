using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHSUNGTUYEN.NhanVien.DAL
{
    internal class PhieuDKQC_DAO
    {
        private string strConn = @"Data Source=LAPTOP-CL7N23GM\SQLEXPRESS;Initial Catalog=QLHSUNGTUYEN;Integrated Security=True";
        public PhieuDKQC_DAO()
        {
        }

        public int ThanhToanPhieuDKQC(int MaDT, int UuDai)
        {
            int totalGiaTien = 0;
           
            try
            {
                using (SqlConnection connection = new SqlConnection(strConn))
                {
                    connection.Open();

                    // Create the SQL query for totalGiaTien
                    string query = "SELECT SUM(GiaTien) FROM PHIEUDKQUANGCAO p " +
                                   "INNER JOIN HINHTHUCDANGTUYEN ht ON p.MaHT = ht.MaHT " +
                                   "WHERE MaDT = @MaDT";

                    // Create the command for totalGiaTien
                    using (SqlCommand commandTotal = new SqlCommand(query, connection))
                    {
                        // Add parameters
                        commandTotal.Parameters.AddWithValue("@MaDT", MaDT);

                        // Execute the query and get the total sum
                        object result = commandTotal.ExecuteScalar();

                        // Convert the result to integer
                        if (result != null && result != DBNull.Value)
                        {
                            totalGiaTien = Convert.ToInt32(result);
                        }
                    }
                }

                // Adjust totalGiaTien with UuDai
                if (UuDai > 0)
                {
                    totalGiaTien = totalGiaTien * UuDai / 100;
                }


                return totalGiaTien;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error in PhieuDKQC_DAO.ThanhToanPhieuDKQC: " + ex.Message, ex);
            }
        }

    }
}
