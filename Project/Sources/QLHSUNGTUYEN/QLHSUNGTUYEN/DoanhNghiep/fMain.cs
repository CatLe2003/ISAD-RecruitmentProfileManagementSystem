using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSUNGTUYEN.DoanhNghiep
{
    public partial class fMain : Form
    {
        public string id = "";
        public fMain(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            fWelcome _fWelcome = new fWelcome();
            AddForm(_fWelcome);
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
        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void phieuDKQCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDSPhieuDKQC _fLapPhieuDKQC = new fDSPhieuDKQC(id);
            AddForm(_fLapPhieuDKQC);
        }
    }
}
