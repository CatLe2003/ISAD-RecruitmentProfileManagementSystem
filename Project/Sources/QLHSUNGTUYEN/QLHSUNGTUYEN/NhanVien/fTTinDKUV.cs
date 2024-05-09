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
            // Lấy thông tin chi tiết của 1 phiếu đktvuv dựa vào mã phiếu
            // được truyền từ form fGhiNhanTVUV
            var row = new Database().Select("XemUVTheoMaPhieu " + maphieu, null);

            txtHoten.Text = row["HOTEN"].ToString();
            txtSDT.Text = row["SDT"].ToString();
            txtDiachi.Text = row["DIACHI"].ToString();
            txtEmail.Text = row["Email"].ToString();

            string gioitinh = row["GIOITINH"].ToString();

            if (gioitinh == "Male")
            {
                radioMale.Checked = true;
            }
            else
            {
                radioFemale.Checked = true;
            }
        }
    }
}
