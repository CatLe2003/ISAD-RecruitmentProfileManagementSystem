using QLHSUNGTUYEN.UngVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLHSUNGTUYEN.DoanhNghiep
{
    public partial class fDangKyTVDN : Form
    {
        private DangKyTVDNBus DangKyTVDNBus;

        public fDangKyTVDN()
        {
            InitializeComponent();
            DangKyTVDNBus = new DangKyTVDNBus();
            ClearInputFields();
        }

        private void fDangKyTVDN_Load(object sender, EventArgs e)
        {

        }

        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            string TenDN = txtTenDN.Text;
            string MaSoThue = txtMaSoThue.Text;
            string NguoiDaiDien = txtNguoiDaiDien.Text;
            string Diachi = txtDiachi.Text;
            string Email = txtEmail.Text;
            string Pass_word = txtPass.Text;

            bool registrationSuccess = DangKyTVDNBus.RegisterDoanhNghiep(TenDN, MaSoThue, NguoiDaiDien, Diachi, Email, Pass_word);
            if (registrationSuccess)
            {
                ClearInputFields();
            }
        }
        private void ClearInputFields()
        {
            txtTenDN.Text = "";
            txtMaSoThue.Text = "";
            txtNguoiDaiDien.Text = "";
            txtDiachi.Text = "";
            txtEmail.Text = "";
            txtPass.Text = "";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLogin _fLogin = new fLogin();
            _fLogin.Show();
        }
    }
}
