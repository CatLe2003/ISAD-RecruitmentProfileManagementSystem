using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHSUNGTUYEN.NhanVien.BLL
{
    internal class DNghiep
    {
        public int MaDN { get; set; }
		//public int ID; 
		public string Pass_word;
		public string TenDN { get; set; }
		public string MaSoThue;
		public string NguoiDaiDien;
		public string Diachi;
		public string Email;
		public string TiemNang;
		//public int MaPhieuDKDN; //FK

		public DNghiep()
		{

		}
        public List<DNghiep> DanhSachDoanhNghiep()
        {
            List<DNghiep> list = new List<DNghiep>();
            DataTable all_DNgiep = new Database().SelectData("GetDoanhNghiep", null);
            foreach (DataRow row in all_DNgiep.Rows)
            {
                list.Add(new DNghiep() { TenDN = row["TenDN"].ToString(), MaDN = int.Parse(row["MaDN"].ToString()) });
            }
            return list;
        }
		
    }

         
	
}
