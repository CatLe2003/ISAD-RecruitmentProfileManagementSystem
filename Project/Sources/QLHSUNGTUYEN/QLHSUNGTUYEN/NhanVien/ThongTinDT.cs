using QLHSUNGTUYEN.NhanVien.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSUNGTUYEN.NhanVien.BLL
{
    internal class ThongTinDT
    {
        public int MaDT;
        DNghiep MaDN;
        public DateTime NgDangTuyen;
        public DateTime NgHetHan;
        public int SoLuong;
        public string ViTri;
        public string YeuCau;

        public ThongTinDT()
        {
        }

        public bool KiemTraThongTinDT(int MaDT)
        {
            bool success;
            //Call DAO to check if MaDT exists
            ThongTinDT_DAO thongTinDT_DAO = new ThongTinDT_DAO();
            int result = thongTinDT_DAO.DocTTDT(MaDT);

            if (result == 0) //If MaDT does not exist
            {
                MessageBox.Show("MaDT does not exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = false;
                return success;
            }
            else
            {
                success = true;
                return success;
            }
        }


        public bool KiemTraMaDTTUMaDN(ThongTinDT ttdt, DNghiep dn)
        {
            ThongTinDT_DAO thongTinDT_DAO = new ThongTinDT_DAO();
            int result = thongTinDT_DAO.DocTTMaDTCuaDN(ttdt.MaDT, dn.MaDN);

            if (result == 1) //If MaDT does not match MaDN
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
