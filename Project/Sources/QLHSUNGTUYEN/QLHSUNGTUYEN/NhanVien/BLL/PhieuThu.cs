using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Windows.Forms;
using System.Data;

namespace QLHSUNGTUYEN
{
    internal class PhieuThu
    {
        public int MaNV { get; set; }
        public int DotThu { get; set; }
        public DateTime NgayThu { get; set; }
        public int SoTien { get; set; }
        public int MaHDong { get; set; }

        public bool LapPhieuThu() {
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter()
            {
                key = "@MaNV",
                value = MaNV.ToString()
            });
            parameters.Add(new CustomParameter()
            {
                key = "@DotThu",
                value = DotThu.ToString()
            });
            parameters.Add(new CustomParameter()
            {
                key = "@NgayThu",
                value = NgayThu.ToString("dd/MM/yyyy")
            });
            parameters.Add(new CustomParameter()
            {
                key = "@SoTien",
                value = SoTien.ToString()
            });
            parameters.Add(new CustomParameter()
            {
                key = "@MaHDong",
                value = MaHDong.ToString()
            });
            var res = new Database().ExeCute("LapPhieuThu", parameters);
            if (res == 1) // nếu thực thi thành công
            {
                return true;
            }
            else // nếu không thành công
            {
                return false;
            }
        }
        public int TimDotThuLonNhat(string maHDong)
        {
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter()
            {
                key = "@MaHDong",
                value = maHDong.ToString()
            });
            DataTable DotThu = new Database().SelectData("TimDotThuLonNhat", parameters);
            return int.Parse(DotThu.Rows[0]["DotThu"].ToString());
            
        }
    }
}
