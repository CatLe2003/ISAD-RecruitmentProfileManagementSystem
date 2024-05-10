using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHSUNGTUYEN.NhanVien
{
    internal class GhiNhanTVUVBus
    {
        public DataTable LoadPhieuDKTVUV(string maphieu, string keyword)
        {
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter()
            {
                key = "@maphieu",
                value = maphieu
            });
            parameters.Add(new CustomParameter()
            {
                key = "@keyword",
                value = keyword
            });

            // Call the data access layer to fetch data
            return new Database().SelectData("XemDSPhieuDKTVUngVien", parameters);
        }

        public int UpdateTrangThaiPhieuDKTVUV(string maphieu, string manv, string trangthai)
        {
            string sql = "UpdateTrangThaiPhieuDKTVUV";

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

            // Truyền 2 tham số là câu lệnh sql và danh sách các tham số
            return new Database().ExeCute(sql, parameters);
        }
    }
}
