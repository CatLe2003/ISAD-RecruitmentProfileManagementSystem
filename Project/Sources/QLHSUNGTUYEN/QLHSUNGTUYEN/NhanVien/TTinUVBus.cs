using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHSUNGTUYEN.NhanVien
{
    internal class TTinUVBus
    {
        public static DataRow GetUngVienDetails(string maphieu)
        {
            // Call the data access layer to retrieve user details based on the provided maphieu

            // Lấy thông tin chi tiết của 1 phiếu đktvuv dựa vào mã phiếu
            // được truyền từ form fGhiNhanTVUV
            return new Database().Select("XemUVTheoMaPhieu " + maphieu, null);
        }
    }
}
