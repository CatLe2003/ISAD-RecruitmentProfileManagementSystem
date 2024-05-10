using QLHSUNGTUYEN.NhanVien.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSUNGTUYEN.NhanVien.BLL
{
    
    internal class LapHopDong_Controller
    {
        NVien MaNV;
        DNghiep MaDN;

        HopDong NgKy;
        HopDong NgHetHan;
        HopDong NoiDung;
        HopDong SoDotTT;
        HopDong SoTienTT;
        HopDong UuDai;
        HopDong TinhTrangKyDuyet;

        /*public DateTime NgKy;
        public DateTime NgHetHan;
        public string NoiDung = "";
        public int SoDotTT;
        public int SoTienTT;
        public int UuDai;
        public string TinhTrangKyDuyet = "";*/

        NVien NVien = new NVien();
        DNghiep DNghiep = new DNghiep();
        HopDong HopDong = new HopDong();


        //Call method from BLL - Class HopDong 
        public bool GhiNhanHopDong(NVien NVien, DNghiep DNghiep, HopDong HopDong)
        {
            try
            {
                bool success = HopDong.GhiNhanHopDong(NVien, DNghiep, HopDong);
                if (success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions here (e.g., log error, throw custom exception)
                throw new ApplicationException("Error in LapHopDong_Controller.GhiNhanHopDong: " + ex.Message, ex);
            }
        }

    }

   

}
