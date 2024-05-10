using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSUNGTUYEN.NhanVien
{
    public partial class fTTinDKDN : Form
    {
        private string maphieu = "";

        public fTTinDKDN(string maphieu)
        {
            this.maphieu = maphieu;
            InitializeComponent();
        }

        private void fTTinDKDN_Load(object sender, EventArgs e)
        {
            // Retrieve user details using the business logic layer
            DataRow DNDetails = TTinDNBus.GetDoanhNghiepDetails(maphieu);

            if (DNDetails != null)
            {
                // Populate the form with user details
                txtTenDN.Text = DNDetails["TenDN"].ToString();
                txtMaSoThue.Text = DNDetails["MaSoThue"].ToString();
                txtNguoiDaiDien.Text = DNDetails["NguoiDaiDien"].ToString();
                txtDiachi.Text = DNDetails["DiaChi"].ToString();
                txtEmail.Text = DNDetails["Email"].ToString();

            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin doanh nghiệp!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
