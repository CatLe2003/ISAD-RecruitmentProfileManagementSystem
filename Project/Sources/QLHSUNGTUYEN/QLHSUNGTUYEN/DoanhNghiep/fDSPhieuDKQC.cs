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
using static System.Windows.Forms.AxHost;

namespace QLHSUNGTUYEN
{
    public partial class fDSPhieuDKQC : Form
    {
        private string madn = "";
        private string keyword = "";

        public fDSPhieuDKQC(string madn)
        {
            this.madn = madn;
            InitializeComponent();
        }
        private void LoadPhieuDKQC()
        {
            dgvPhieuDKQC.DataSource = null; // reset lại csdl được hiển thị
            // load toàn bộ danh sách phiếu đăng ký quảng cáo của doanh nghiệp
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter()
            {
                key = "@madn",
                value = madn
            });
            parameters.Add(new CustomParameter()
            {
                key = "@keyword",
                value = keyword
            });
            
            dgvPhieuDKQC.DataSource = new Database().SelectData("XemPhieuDKQC_DoanhNghiep", parameters);
        }
        private void fLapPhieuDKQC_Load(object sender, EventArgs e)
        {
            LoadPhieuDKQC();
        }

        private void dgvPhieuDKQC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvPhieuDKQC.Rows[index];
            Console.WriteLine(selectedRow);
            if (selectedRow != null)
            {
                //MessageBox.Show("MaHT:"+ selectedRow.Cells["Mã hình thức"].Value.ToString());
                var maht = selectedRow.Cells["Mã hình thức"].Value.ToString();
                var madt = selectedRow.Cells["Mã đăng tuyển"].Value.ToString();
                
                // Truyền mã hình thức vào form phiếu đk quảng cáo
                new fPhieuDKQC(madn, maht, madt).ShowDialog();

                // Sau khi fPhieuDKQC được đóng lại
                // Load lại ds phiếu đk quảng cáo
                LoadPhieuDKQC();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new fPhieuDKQC(madn, null, null).ShowDialog();
            LoadPhieuDKQC();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            keyword = txtKeyword.Text;
            LoadPhieuDKQC();
        }

        private void dgvPhieuDKQC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int col_index = dgvPhieuDKQC.Columns["btnDelete"].Index;
            if (index >= 0)
            {
                if (e.ColumnIndex == col_index)
                {
                    var maht = dgvPhieuDKQC.Rows[index].Cells["Mã hình thức"].Value.ToString();
                    var madt = dgvPhieuDKQC.Rows[index].Cells["Mã đăng tuyển"].Value.ToString();

                    if (MessageBox.Show(
                        "Bạn chắc chắn muốn xóa phiếu đăng ký quảng cáo: " + maht + ", " + madt + " ?",
                        "Xác nhận xóa!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                        ) == DialogResult.Yes)
                    {
                        var sql = "XoaPhieuDKQuangCao"; // gọi thủ tục
                    
                        List<CustomParameter> parameters = new List<CustomParameter>();
                        parameters.Add(new CustomParameter()
                        {
                            key = "@MaHT",
                            value = maht.ToString()
                        });
                        parameters.Add(new CustomParameter()
                        {
                            key = "@MaDT",
                            value = madt.ToString()
                        });

                        // Truyền 2 tham số là câu lệnh sql và danh sách các tham số
                        var res = new Database().ExeCute(sql, parameters);
                        if (res == 1) // nếu thực thi thành công
                        {
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else // nếu không thành công
                        {
                            Console.WriteLine(res);
                            MessageBox.Show("Error: Thực thi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }                  
                // Load lại ds phiếu đk quảng cáo
                LoadPhieuDKQC();
            }
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblKeyword_Click(object sender, EventArgs e)
        {

        }
    }
}
