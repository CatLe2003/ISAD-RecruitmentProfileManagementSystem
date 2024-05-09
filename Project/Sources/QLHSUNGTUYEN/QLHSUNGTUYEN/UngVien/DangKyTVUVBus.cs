using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSUNGTUYEN.UngVien
{
    internal class DangKyTVUVBus
    {
        public bool RegisterUngVien(string hoten, string sdt, string gioitinh, string diachi, string email, string password)
        {
            // Validate input parameters
            if (string.IsNullOrEmpty(hoten) || string.IsNullOrEmpty(sdt)
                || string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(email)
                || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(gioitinh))
            {
                MessageBox.Show("Yêu cầu điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the email is already registered
            if (IsEmailRegistered(email))
            {
                MessageBox.Show("Email đã được sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Register the job applicant
            bool registrationSuccess = InsertUngVien(hoten, sdt, gioitinh, diachi, email, password);
            if (registrationSuccess)
            {
                MessageBox.Show("Đã gửi yêu cầu xác thực!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Error: Vui lòng kiểm tra lại Email hoặc Password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool IsEmailRegistered(string email)
        {
            string sql_check = "CheckEmailRegistered";
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter()
            {
                key = "@Email",
                value = email.ToString()
            });

            var res = new Database().SelectData(sql_check, parameters);
            return res.Rows.Count == 1;
        }

        private bool InsertUngVien(string hoten, string sdt, string gioitinh, string diachi, string email, string password)
        {
            string sql_insertUV = "InsertUngVien";
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter()
            {
                key = "@Email",
                value = email.ToString()
            });
            parameters.Add(new CustomParameter()
            {
                key = "@SDT",
                value = sdt.ToString()
            });
            parameters.Add(new CustomParameter()
            {
                key = "@Hoten",
                value = hoten.ToString()
            });
            parameters.Add(new CustomParameter()
            {
                key = "@Gioitinh",
                value = gioitinh.ToString()
            });
            parameters.Add(new CustomParameter()
            {
                key = "@Diachi",
                value = diachi.ToString()
            });
            parameters.Add(new CustomParameter()
            {
                key = "@Pass_word",
                value = password.ToString()
            });

            int res = new Database().ExeCute(sql_insertUV, parameters);
            return res != 0;
        }
    }
}
