using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHSUNGTUYEN.NhanVien.Forms;

namespace QLHSUNGTUYEN.NhanVien
{
    public partial class fMain_NV : Form
    {
        public string id = "";
        public fMain_NV(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void AddForm(Form f)
        {
            this.pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }

        private void UVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fGhiNhanTVUV _fGhiNhanTVUV = new fGhiNhanTVUV(id);
            AddForm(_fGhiNhanTVUV);
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HopDongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLapHopDong _fLapHopDong = new fLapHopDong();
            AddForm(_fLapHopDong);
        }
    }
}
