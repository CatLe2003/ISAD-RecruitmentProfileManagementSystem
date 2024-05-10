using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSUNGTUYEN.DoanhNghiep
{
    internal class DangKyTVDNBus
    {

        public bool RegisterDoanhNghiep(string TenDN, string MaSoThue, string NguoiDaiDien, string Diachi, string Email, string Pass_word)
        {
            // Validate input parameters
            if (string.IsNullOrEmpty(TenDN) || string.IsNullOrEmpty(MaSoThue)
                || string.IsNullOrEmpty(NguoiDaiDien) || string.IsNullOrEmpty(Diachi)
                || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Pass_word))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (MaSoThue.Length > 10)
            {
                MessageBox.Show("Mã số thuế không hợp lệ (MST nhiều hơn 10 kí tự). Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Check if the email is already registered
            if (IsEmailRegistered(Email))
            {
                MessageBox.Show("Email đã được sử dụng! Vui lòng sử dụng email khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            bool registrationSuccess = InsertDoanhNghiep(TenDN, MaSoThue, NguoiDaiDien, Diachi, Email,Pass_word);
            if (registrationSuccess)
            {
                MessageBox.Show("Đăng ký tài khoản thành công, vui lòng chờ nhân viên xác thực tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string proc_name = "CheckEmailRegisteredDoanhNghiep";
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter()
            {
                key = "@Email",
                value = email.ToString()
            });

            var res = new Database().SelectData(proc_name, parameters);
            return res.Rows.Count == 1;
        }

        private bool InsertDoanhNghiep(string TenDN, string MaSoThue, string NguoiDaiDien, string Diachi, string Email, string Pass_word)
        {
            string proc_name = "InsertDoanhNghiep";
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter()
            {
                key = "@TenDN",
                value = TenDN.ToString()
            });
            parameters.Add(new CustomParameter()
            {
                key = "@MaSoThue",
                value = MaSoThue.ToString()
            });
            parameters.Add(new CustomParameter()
            {
                key = "@NguoiDaiDien",
                value = NguoiDaiDien.ToString()
            });
            parameters.Add(new CustomParameter()
            {
                key = "@Diachi",
                value = Diachi.ToString()
            });
            parameters.Add(new CustomParameter()
            {
                key = "@Email",
                value = Email.ToString()
            });
            parameters.Add(new CustomParameter()
            {
                key = "@Pass_word",
                value = Pass_word.ToString()
            });

            int res = new Database().ExeCute(proc_name, parameters);
            return res != 0;
        }
    }
}
