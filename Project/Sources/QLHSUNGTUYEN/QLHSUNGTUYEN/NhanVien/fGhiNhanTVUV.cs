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
    public partial class fGhiNhanTVUV : Form
    {
        private string maphieu = "";
        private string keyword = "";

        public fGhiNhanTVUV()
        {
            InitializeComponent();
        }

        private void lblKeyword_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fGhiNhanTVUV_Load(object sender, EventArgs e)
        {
            dgvDSPhieuUV.DataSource = null; // reset lại csdl được hiển thị
            // load toàn bộ danh sách phiếu đăng ký thành viên ứng viên
            List<CustomParameter> parameters = new List<CustomParameter>();

            dgvDSPhieuUV.DataSource = new Database().SelectData("XemDSPhieuDKTVUngVien", parameters);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            keyword = txtKeyword.Text;
            fGhiNhanTVUV_Load(sender, e);
        }
    }
}
