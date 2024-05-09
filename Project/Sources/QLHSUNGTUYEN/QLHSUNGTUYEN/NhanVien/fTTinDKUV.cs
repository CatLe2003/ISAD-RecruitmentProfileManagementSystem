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
    public partial class fTTinDKUV : Form
    {
        private string maphieu = "";

        public fTTinDKUV(string maphieu)
        {
            this.maphieu = maphieu;
            InitializeComponent();
        }

        private void fTTinDKUV_Load(object sender, EventArgs e)
        {
            // Retrieve user details using the business logic layer
            DataRow uvDetails = TTinUVBus.GetUngVienDetails(maphieu);

            if (uvDetails != null)
            {
                // Populate the form with user details
                txtHoten.Text = uvDetails["HOTEN"].ToString();
                txtSDT.Text = uvDetails["SDT"].ToString();
                txtDiachi.Text = uvDetails["DIACHI"].ToString();
                txtEmail.Text = uvDetails["Email"].ToString();

                string gioitinh = uvDetails["GIOITINH"].ToString();

                if (gioitinh == "Male")
                {
                    radioMale.Checked = true;
                }
                else
                {
                    radioFemale.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin ứng viên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
