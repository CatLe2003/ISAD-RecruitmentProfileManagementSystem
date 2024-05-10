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
        private DangKyTVUVBus DangKyTVUVBus;
        public fDangKyTVUV()
        {
            InitializeComponent();
            DangKyTVUVBus = new DangKyTVUVBus(); 
            ClearInputFields();
        }

        private void fDangKyTVUV_Load(object sender, EventArgs e)
        {

        }

        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            string hoten = txtHoten.Text;
            string sdt = txtSDT.Text;
            string diachi = txtDiachi.Text;
            string email = txtEmail.Text;
            string password = txtPass.Text;
            string gioitinh = "";

            if (radioMale.Checked == true)
            {
                gioitinh = "Male";
            }
            else
            {
                if (radioFemale.Checked == true)
                {
                    gioitinh = "Female";
                }
                else
                {
                    gioitinh = "";
                }
            }

            bool registrationSuccess = DangKyTVUVBus.RegisterUngVien(hoten, sdt, gioitinh, diachi, email, password);
            if (registrationSuccess)
            {
                // Clear the input fields after successful registration
                ClearInputFields();
            }
        }
        private void ClearInputFields()
        {
            txtHoten.Text = "";
            txtSDT.Text = "";
            txtDiachi.Text = "";
            txtEmail.Text = "";
            txtPass.Text = "";
            radioMale.Checked = false;
            radioFemale.Checked = false;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLogin _fLogin = new fLogin();
            _fLogin.Show();
        }
    }
}
