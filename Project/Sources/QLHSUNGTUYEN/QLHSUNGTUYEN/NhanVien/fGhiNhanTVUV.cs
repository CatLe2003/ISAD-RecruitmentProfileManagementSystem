using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSUNGTUYEN.NhanVien
{
    public partial class fGhiNhanTVUV : Form
    {
        private string maphieu = "";
        private string trangthai = "";
        private string manv = "";
        private GhiNhanTVUVBus ghiNhanTVUVBus;
        private string keyword = "";
        public fGhiNhanTVUV(string manv)
        {
            this.manv = manv;
            InitializeComponent();
            ghiNhanTVUVBus = new GhiNhanTVUVBus();
            ClearInputFields();
            fGhiNhanTVUV_Load(null, null);
        }

        private void fGhiNhanTVUV_Load(object sender, EventArgs e)
        {
            dgvDSPhieuUV.DataSource = ghiNhanTVUVBus.LoadPhieuDKTVUV(keyword);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            keyword = txtKeyword.Text;
            fGhiNhanTVUV_Load(sender, e);
        }

        private void dgvDSPhieuUV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvDSPhieuUV.Rows[index];
            Console.WriteLine(selectedRow);
            if (selectedRow != null)
            {
                txtMaphieu.Text = selectedRow.Cells["Mã phiếu"].Value.ToString();
                txtID.Text = selectedRow.Cells["ID"].Value.ToString();
                txtMaNV.Text = selectedRow.Cells["Mã NV xét duyệt"].Value.ToString();

                string ngayLapString = selectedRow.Cells["Ngày lập"].Value.ToString();

                DateTime ngayLap = DateTime.ParseExact(ngayLapString, "dd/MM/yyyy", null);
                txtNgaylap.Text = ngayLap.ToString("dd/MM/yyyy");


                trangthai = selectedRow.Cells["Trạng thái"].Value.ToString();

                switch (trangthai)
                {
                    case "Valid":
                        radioValid.Checked = true;
                        break;
                    case "Invalid":
                        radioInvalid.Checked = true;
                        break;
                    case "Pending":
                        radioPending.Checked = true;
                        break;
                    default:
                        // Handle unexpected values here, if needed
                        break;
                }

                txtID.Enabled = false;
                txtMaphieu.Enabled = false;
                txtMaNV.Enabled = false;
                txtNgaylap.Enabled = false;

                maphieu = txtMaphieu.Text;
            }
        }

        private void ClearInputFields()
        {
            txtMaphieu.Text = "";
            txtID.Text = "";
            txtMaNV.Text = "";
            txtNgaylap.Text = "";
            radioValid.Checked = false;
            radioInvalid.Checked = false;
            radioPending.Checked = false;
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {

            if (radioInvalid.Checked)
            {
                trangthai = "Invalid";
            }
            else
            {
                if (radioValid.Checked)
                {
                    trangthai = "Valid";
                }
                else
                {
                    trangthai = "Pending";
                }
            }

            int res = ghiNhanTVUVBus.UpdateTrangThaiPhieuDKTVUV(maphieu, manv, trangthai);

            if (res != 0) // nếu thực thi thành công
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // nếu không thành công
            {
                Console.WriteLine(res);
                MessageBox.Show("Error!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            fGhiNhanTVUV_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void dgvDSPhieuUV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new fTTinDKUV(maphieu).ShowDialog();
        }
    }
}
