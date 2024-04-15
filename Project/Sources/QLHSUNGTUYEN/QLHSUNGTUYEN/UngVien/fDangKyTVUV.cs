using QLHSUNGTUYEN.DoanhNghiep;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSUNGTUYEN.UngVien
{
    public partial class fDangKyTVUV : Form
    {
        public string hoten = "";
        public string sdt = "";
        public string gioitinh = "";
        public string diachi = "";
        public string email = "";
        public string password = "";

        public fDangKyTVUV()
        {
            InitializeComponent();
        }

        private void fDangKyTVUV_Load(object sender, EventArgs e)
        {

        }

        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoten.Text) || string.IsNullOrEmpty(txtSDT.Text)
                || string.IsNullOrEmpty(txtDiachi.Text) || string.IsNullOrEmpty(txtEmail.Text)
                || string.IsNullOrEmpty(txtPass.Text) || (radioFemale.Checked == false && radioMale.Checked == false))
            {
                MessageBox.Show("Yêu cầu điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    

            hoten = txtHoten.Text;
            sdt = txtSDT.Text;
            diachi = txtDiachi.Text;   
            email = txtEmail.Text;
            password = txtPass.Text;

            if (radioMale.Checked ==true)
            {
                gioitinh = "Male";
            } 
            else
            {
                gioitinh = "Female";
            }

            // procedure
            string sql_check = "CheckEmailRegistered";
            string sql_insertUV = "InsertUngVien";

            // paremeters
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter()
            {
                key = "@Email",
                value = email.ToString()
            });

            var res = new Database().SelectData(sql_check, parameters);

            if (res.Rows.Count==1) // nếu thực thi thành công
            {
                MessageBox.Show("Email đã được sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = "";
                return;
            }
            else 
            {
                Console.WriteLine(res);
            }

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

            // Truyền 2 tham số là câu lệnh sql và danh sách các tham số
            var res1 = new Database().ExeCute(sql_insertUV, parameters);

            if (res1 != 0) // nếu thực thi thành công
            {
                MessageBox.Show("Đã gửi yêu cầu xác thực!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.Dispose();
            }
            else // nếu không thành công
            {
                Console.WriteLine(res);
                MessageBox.Show("Error: Vui lòng kiểm tra lại Email hoặc Password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
