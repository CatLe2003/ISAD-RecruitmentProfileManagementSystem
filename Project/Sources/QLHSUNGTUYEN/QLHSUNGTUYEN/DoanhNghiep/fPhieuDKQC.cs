using QLHSUNGTUYEN.DoanhNghiep;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace QLHSUNGTUYEN
{
    public partial class fPhieuDKQC : Form
    {
        private string madn = "";
        private string maht = "";
        private string madt = "";
        public static string State = "-1";

        public fPhieuDKQC(string madn, string maht, string madt)
        {
            this.madn = madn;
            this.maht = maht;
            this.madt = madt;
            InitializeComponent();
            fPhieuDKQC_Load(null, null);
        }

        private void fPhieuDKQC_Load(object sender, EventArgs e)
        {
            // nếu không có madt, maht => thêm mới phiếu đăng ký quảng cáo
            if (string.IsNullOrEmpty(maht) || string.IsNullOrEmpty(madt))
            {
                this.Text = "Thêm mới phiếu đăng ký quảng cáo";
                State = "Insert";
                cbbMaHT.Enabled = true;
                cbbMaDT.Enabled = true;
            }
            else
            {
                this.Text = "Cập nhật phiếu đăng ký quảng cáo";
                State = "Update";
                cbbMaHT.Enabled = false;
                cbbMaDT.Enabled = false;

                // Lấy thông tin chi tiết của 1 phiếu đk quảng cáo dựa vào mã ht và madt
                // maht, madt được truyền từ form fDSPhieuDKQC
                var row = new Database().Select("XemPhieuDKQuangCao " + maht + "," + madt, null);
                
                // Set các giá trị vào component của form
                cbbMaDT.Text = row["MaDT"].ToString();
                if (int.Parse(row["MaHT"].ToString()) == 1)
                {
                    cbbMaHT.Text = "Báo giấy";
                }
                else if (int.Parse(row["MaHT"].ToString()) == 2) 
                {
                    cbbMaHT.Text = "Banner quảng cáo";
                }
                else
                {
                    cbbMaHT.Text = "Trang mạng";
                }
                cbbMaHDong.Text = row["MaHDong"].ToString();
                mtbNgayLap.Text = row["NgayLap"].ToString();
            }

            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter()
            {
                key = "@MaDN",
                value = madn.ToString()
            });

            DataTable all_HinhThuDT = new Database().SelectData("GetTenHinhThucDangTuyen", null);
            foreach (DataRow row in all_HinhThuDT.Rows)
            {
                cbbMaHT.Items.Add(row["TenHinhThuc"].ToString());
            }

            DataTable MaDT_byMaDN = new Database().SelectData("GetMaThongTinDangTuyenByMaDN", parameters);
            foreach (DataRow row in MaDT_byMaDN.Rows)
            {
                cbbMaDT.Items.Add(row["MaDT"].ToString());
            }

            DataTable MaHDong_byMaDN = new Database().SelectData("GetMaHopDongByMaDN", parameters);
            foreach (DataRow row in MaHDong_byMaDN.Rows)
            {
                cbbMaHDong.Items.Add(row["MaHDong"].ToString());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // TH1: Nếu madt, maht không có giá trị -> thêm mới phiếu dk quảng cáo
            // TH2: Nếu madt, maht có giá trị -> cập nhật phiếu dk quảng cáo

            string sql = "";
            string madt = cbbMaDT.Text;
            string mahdong = cbbMaHDong.Text;
            int maht = 0;
            string ngaylap = mtbNgayLap.Text;

            if (cbbMaHT.Text == "Báo giấy")
            {
                maht = 1;
            }
            else if (cbbMaHT.Text == "Banner quảng cáo")
            {
                maht = 2;
            }
            else if (cbbMaHT.Text == "Trang mạng")
            {
                maht = 3;
            }
            else { maht = 0; }

            List<CustomParameter> parameters = new List<CustomParameter>();

            // Nếu thêm mới phiếu dk quảng cáo
            if (State == "Insert")
            {
                DateTime ngay_lap;
                /*
                NgayLap ở masketbox có dạng dd/mm/yyyy
                Nhưng trong CSDL lưu dưới dạng yyyy-mm-dd
                -> Cần chuyển từ dd/mm/yyyy => yyyy-mm-dd
                */
                try
                {
                    ngay_lap = DateTime.ParseExact(mtbNgayLap.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    ngay_lap.ToString("yyyy-mm-dd");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Ngày lập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mtbNgayLap.Select();
                    return;
                }

                sql = "ThemPhieuDKQuangCao"/* + maht + "," + madt + "," + mahdong + ",'" + ngay_lap + "'"*/; // gọi tới procedure thêm phiếu đk quảng cáo
            }
            else if (State == "Update")
            {
                sql = "CapNhatPhieuDKQuangCao" /*+ maht + "," + madt + "," + mahdong + ",'" + ngaylap + "'"*/;
            }

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
            parameters.Add(new CustomParameter()
            {
                key = "@MaHDong",
                value = mahdong.ToString()
            });
            parameters.Add(new CustomParameter()
            {
                key = "@NgayLap",
                value = ngaylap
            });

            // Truyền 2 tham số là câu lệnh sql và danh sách các tham số
            var res = new Database().ExeCute(sql, parameters);
            if (res == 1) // nếu thực thi thành công
            {
                if (State == "Insert")
                {
                    MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Dispose(); // đóng form sau khi thêm mới/cập nhật thành công
            }
            else // nếu không thành công
            {
                Console.WriteLine(res);
                MessageBox.Show("Error: Thực thi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
