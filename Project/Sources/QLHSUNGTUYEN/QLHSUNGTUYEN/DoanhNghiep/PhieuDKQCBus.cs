using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Windows.Forms;

namespace QLHSUNGTUYEN.DoanhNghiep
{
    internal class PhieuDKQCBus
    {
        public static int GhiNhanPhieuDKQC(string State, int maht, string mahdong, string madt, string ngaylap)
        {
            string sql = "";
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
                    ngay_lap = DateTime.ParseExact(ngaylap, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    ngay_lap.ToString("yyyy-mm-dd");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Ngày lập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
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
            return res;
        }
    }
}
