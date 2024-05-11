using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHSUNGTUYEN.NhanVien.BLL
{
    internal class NVien
    {
        public int MaNV { get; set; }
        public int ID;
        public string Pass_word;
        public string Hoten { get; set; }
        public string Gioitinh;
        public string Sdt;
        public string Diachi;
        public string Email;
        public string LoaiNV;

        public NVien()
        {

        }
        public string LayTenNhanVien(string manv) {
            MaNV = int.Parse(manv);
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter()
            {
                key = "@MaNV",
                value = manv.ToString()
            });
            DataTable nhanvien = new Database().SelectData("GetTenNhanVien", parameters);
            DataRow nhanvien_ = nhanvien.Rows[0];
            Hoten = nhanvien_["Hoten"].ToString();
            return Hoten.ToString();
        }
    }
}
