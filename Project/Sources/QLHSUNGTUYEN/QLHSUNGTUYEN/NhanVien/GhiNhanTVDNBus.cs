using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHSUNGTUYEN.NhanVien
{
    internal class GhiNhanTVDNBus
    {
       public DataTable LoadPhieuDKTVDN(string keyword)
        {
            List<CustomParameter> parameters = new List<CustomParameter>();

            parameters.Add(new CustomParameter()
            {
                key = "@keyword",
                value = keyword
            });

            return new Database().SelectData("XemDSPhieuDKTVDN", parameters);
        }

        public int UpdateTrangThaiPhieuDKTVDN(string maphieu, string manv, string trangthai)
        {
            string sql = "UpdateTrangThaiPhieuDKTVDN";

            // parameters
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter()
            {
                key = "@maphieu",
                value = maphieu
            });
            parameters.Add(new CustomParameter()
            {
                key = "@manv",
                value = manv
            });
            parameters.Add(new CustomParameter()
            {
                key = "@trang_thai",
                value = trangthai
            });

            return new Database().ExeCute(sql, parameters);
        }
    }
}
