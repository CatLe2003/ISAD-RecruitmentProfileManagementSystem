using QLHSUNGTUYEN.DoanhNghiep;
using QLHSUNGTUYEN.NhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSUNGTUYEN
{
    public partial class fLogin : Form
    {
        public string vaitro = "";
        public string email = "";
        public string password = "";
        public string loaitk = "";
        public string user_id = "";
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            #region ktra_rbuoc
            // Kiểm tra ràng buộc
            if (cbbVaiTro.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbVaiTro.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập email!", "Email không được để trống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập password!", "Password không được để trống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Select();
                return;
            }
            #endregion

            vaitro = cbbVaiTro.Text;
            email = txtUsername.Text;
            password = txtPassword.Text;

            #region switchtk
            switch (cbbVaiTro.Text)
            {
                case "Doanh nghiệp":
                    loaitk = "dn";
                    break;
                case "Ứng viên":
                    loaitk = "uv";
                    break;
                case "Nhân viên":
                    loaitk = "nv";
                    break;
            }
            #endregion

            // procedure
            string sql_check = "CheckLogin";
            string sql_getid = "GetUserID";

            // paremeters
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter()
            {
                key = "@LoaiTK",
                value = loaitk.ToString()
            });
            parameters.Add(new CustomParameter()
            {
                key = "@Email",
                value = email.ToString()
            });
            parameters.Add(new CustomParameter()
            {
                key = "@Password",
                value = password.ToString()
            });

            // Truyền 2 tham số là câu lệnh sql và danh sách các tham số
            var res = new Database().SelectData(sql_check, parameters);
            var row = new Database().Select(sql_getid, parameters);
            user_id = row["UserID"].ToString();

            if (res.Rows.Count > 0) // nếu thực thi thành công
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                switch (loaitk)
                {
                    case "dn":
                        DoanhNghiep.fMain _fMain = new fMain(user_id);
                        _fMain.Show();
                        break;
                    case "uv":
                        loaitk = "uv";
                        break;
                    case "nv":
                        NhanVien.fMain_NV _fMainNV = new fMain_NV(user_id);
                        _fMainNV.Show();
                        break;
                }
                this.Hide();
            }
            else // nếu không thành công
            {
                Console.WriteLine(res);
                MessageBox.Show("Error: Vui lòng kiểm tra lại Email hoặc Password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            
            var db = new Database();
            
            cbbVaiTro.Items.Add("Doanh nghiệp");
            cbbVaiTro.Items.Add("Ứng viên");
            cbbVaiTro.Items.Add("Nhân viên");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đăng kí tài khoản doanh nghiệp? (Nếu chọn không sẽ tự động chuyển sang tài khoản ứng viên)", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // User chose Yes, perform the action
            }
            else
            {
                this.Hide();
                UngVien.fDangKyTVUV _fDangKyTVUV = new UngVien.fDangKyTVUV();
                _fDangKyTVUV.Show();
            }
        }
    }
}
