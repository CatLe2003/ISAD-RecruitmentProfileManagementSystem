using QLHSUNGTUYEN.NhanVien.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace QLHSUNGTUYEN.NhanVien.BLL
{
    internal class HopDongg
    {
        public string MaHDong { get; set; }
        //public string ID;
        //public int MaNV;
        //public int MaDN;
        public DateTime NgKy;
        public DateTime NgHetHan;
        public string NoiDung = "";
        public int? PhuLuc;
        public int SoDotTT { get; set; }
        public int SoTienTT;
        public string TinhTrangKyDuyet = "";
        public int UuDai;

        HopDong_DAO hopDong_DAO = new HopDong_DAO();
        NVien nhanVien = new NVien();
        ThongTinDT_DAO thongTinDT_DAO = new ThongTinDT_DAO();

        public bool GhiNhanHopDong(NVien nhanVien, DNghiep doanhNghiep, HopDongg hopDong)
        {
            try
            {
                int result = hopDong_DAO.DocThongTinDNTrongHD(doanhNghiep.MaDN); 
                bool success;
                if (result == 2) //MaDN exists in HOPDONG  
                {
                    //Find the original contract
                    hopDong.PhuLuc = hopDong_DAO.TimKiemHDGoc(doanhNghiep.MaDN);

                    //Insert new contract 
                    success = hopDong_DAO.ThemHopDong(nhanVien.MaNV, doanhNghiep.MaDN, hopDong);
                    return success;
                }
                else if (result == 1) 
                {
                    //PhuLuc is set NULL by default 
                    // Call the data access layer to insert new contract
                    success = hopDong_DAO.ThemHopDong(nhanVien.MaNV, doanhNghiep.MaDN, hopDong);
                    return success;
                }
                else
                {
                    //Display message: MaDN does not exists 
                    MessageBox.Show("MaDN does not exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    success = false;
                    return success;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions here (e.g., log error, throw custom exception)
                throw new ApplicationException("Error in HopDong_DAO.GhiNhanHopDong: " + ex.Message, ex);
            }
        }

        public int TinhTien(ThongTinDT ttdt, HopDongg hd)
        {
            try
            {
                //Call DAO to check if MaDT exists
              
                int result = thongTinDT_DAO.DocTTDT(ttdt.MaDT);

                if (result == 0) //If MaDT does not exist
                {
                    MessageBox.Show("MaDT does not exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }

                //Call DAO to calculate the total amount to be paid
                int tongTien = hopDong_DAO.ThanhToanPhieuDKQC(ttdt.MaDT, hd.UuDai);

                return tongTien;

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error in PhieuDKQC.ThanhToan: " + ex.Message, ex);
            }

        }
        public List<HopDongg> DanhSachHopDong(string MaDN) {
            List<HopDongg> list = new List<HopDongg>();
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter()
            {
                key = "@MaDN",
                value = MaDN.ToString()
            });
            DataTable all_HopDong = new Database().SelectData("GetHopDong", parameters);
            foreach (DataRow row in all_HopDong.Rows)
            {
                list.Add( new HopDongg() { MaHDong = row["MaHDong"].ToString(),  SoDotTT = int.Parse(row["SoDotTT"].ToString()) } );
            }
            return list;
        }
    }
}
