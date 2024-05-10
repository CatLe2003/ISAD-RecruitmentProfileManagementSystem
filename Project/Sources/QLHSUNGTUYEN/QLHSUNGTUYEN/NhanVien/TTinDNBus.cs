using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHSUNGTUYEN.NhanVien
{
    internal class TTinDNBus
    {
        public static DataRow GetDoanhNghiepDetails(string maphieu)
        {
            return new Database().Select("XemDNTheoMaPhieu " + maphieu, null);
        }
    }
}
