using QLHSUNGTUYEN.NhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace QLHSUNGTUYEN.NhanVien
{
    public partial class fPhieuThu : Form
    {
        private string manv = "";
        private PhieuThu thu = new PhieuThu();
        public fPhieuThu(string manv)
        {
            this.manv = manv;
            InitializeComponent();
            fPhieuThu_Load();
        }

        private void fPhieuThu_Load()
        {
            cbbDN.Enabled = true;
            cbbdot.Enabled = true;
            List<DNghiep> list = new DNghiep().DanhSachDoanhNghiep();

            cbbDN.DataSource = list;
            cbbDN.ValueMember = "MaDN";
            cbbDN.DisplayMember = "TenDN";

            lblValue.Text = new NVien().LayTenNhanVien(manv);
            mtbNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            HopDongg hd = cbbhd.SelectedItem as HopDongg;

            // Kiểm tra xem đã chọn hợp đồng và số đợt thanh toán chưa
            if (hd != null && cbbdot.SelectedItem is string soDotTT)
            {
                // Chuyển đổi mã nhân viên từ chuỗi sang số nguyên
                if (int.TryParse(this.manv, out int maNV))
                {
                    // Chuyển đổi ngày từ chuỗi sang đối tượng DateTime
                    if (DateTime.TryParseExact(mtbNgayLap.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayThu))
                    {
                        // Chuyển đổi mã hợp đồng từ chuỗi sang số nguyên
                        if (int.TryParse(hd.MaHDong, out int maHDong))
                        {
                            // Chuyển đổi số tiền từ chuỗi sang số nguyên
                            if (int.TryParse(textBox1.Text, out int soTien))
                            {
                                // Chuyển đổi số đợt thanh toán từ chuỗi sang số nguyên
                                if (int.TryParse(soDotTT, out int dotThu))
                                {
                                    thu.MaNV = maNV;
                                    thu.NgayThu = ngayThu;
                                    thu.MaHDong = maHDong;
                                    thu.SoTien = soTien;
                                    thu.DotThu = dotThu;
                                    bool check = thu.LapPhieuThu();
                                    if (check)
                                    {
                                        MessageBox.Show("Lập phiếu thu thành công!");
                                        this.Dispose();
                                    }
                                    // Đã gán giá trị thành công, bạn có thể thực hiện thêm xử lý ở đây
                                }
                                else
                                {
                                    MessageBox.Show("Số đợt thanh toán không hợp lệ!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Số tiền không hợp lệ!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mã hợp đồng không hợp lệ!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ngày thu không hợp lệ! Vui lòng nhập theo định dạng dd/MM/yyyy.");
                    }
                }
                else
                {
                    MessageBox.Show("Mã nhân viên không hợp lệ!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hợp đồng và số đợt thanh toán!");
            }
        }
        private void cbbhd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            HopDongg selectedItem = cbbhd.SelectedItem as HopDongg;
            if (selectedItem != null)
            {
                int i = thu.TimDotThuLonNhat(selectedItem.MaHDong) + 1;
                int soDotTT = selectedItem.SoDotTT;
                cbbdot.Items.Clear();
                for (; i <= soDotTT; i++)
                {
                    cbbdot.Items.Add(i.ToString());
                }
            }
        }

        private void cbbDN_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DNghiep selectedItem = cbbDN.SelectedItem as DNghiep;
            if (selectedItem != null)
            {
                List<HopDongg> list = new HopDongg().DanhSachHopDong(selectedItem.MaDN.ToString());

                cbbhd.DataSource = list;
                cbbhd.ValueMember = "MaHDong";
                cbbhd.DisplayMember = "MaHDong";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
