using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QLHSUNGTUYEN.NhanVien.BLL;

namespace QLHSUNGTUYEN.NhanVien.Forms
{
    public partial class fLapHopDong : Form
    {
        DNghiep doanhNghiep = new DNghiep();
        NVien nhanVien = new NVien();
        HopDongg hopDong = new HopDongg();
        ThongTinDT ttdt = new ThongTinDT();

        public fLapHopDong(string MaNV)
        {
            InitializeComponent();
            nhanVien.MaNV = int.Parse(MaNV); //Pass the employee ID to the form
        }

        private void button1_Click(object sender, EventArgs e) //btn_Ghi
        {

            try
            {
                //Retrieve values from the form's controls
                doanhNghiep.MaDN = int.Parse(textBox5.Text);
                hopDong.NoiDung = textBox6.Text;
                hopDong.SoDotTT = int.Parse(textBox8.Text);
                hopDong.SoTienTT = int.Parse(textBox9.Text);

                //hopDong.UuDai = int.Parse(textBox10.Text);

                //Convert date format 
                hopDong.NgKy = DateTime.ParseExact(textBox4.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                hopDong.NgKy.ToString("yyyy-mm-dd");

                hopDong.NgHetHan = DateTime.ParseExact(textBox3.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                hopDong.NgHetHan.ToString("yyyy-mm-dd");

                if (checkBox1.Checked)
                {
                    hopDong.TinhTrangKyDuyet = "1";
                }
                else
                {
                    hopDong.TinhTrangKyDuyet = "0";
                }
                //Kiem tra MaDT tuong ung voi MaDN
                bool success_1 = ttdt.KiemTraMaDTTUMaDN(ttdt, doanhNghiep);
                if (!success_1)
                {
                    MessageBox.Show("MaDT does not match MaDN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Call the method in the business logic layer to insert the new row
                bool success = hopDong.GhiNhanHopDong(nhanVien, doanhNghiep, hopDong);

                if (success) MessageBox.Show("Contract inserted successfully!");
                else MessageBox.Show("Failed to insert contract.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Reset the form
            textBox1.Text = "";
            //textBox2.Text = "";
            //label2.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox6.Text = "";
            //textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            checkBox1.Checked = false;
            textBox10.Text = "";
        }

        private void button3_Click(object sender, EventArgs e) //btn_TinhTien
        {
            //Retrieve values from the form's controls
            ttdt.MaDT = int.Parse(textBox1.Text);
            hopDong.UuDai = int.Parse(textBox10.Text);

            //Check if MaDT exists
            bool success = ttdt.KiemTraThongTinDT(ttdt.MaDT);
            if (success)
            {
                //Call the method in the business logic layer to calculate the total amount
                int total = hopDong.TinhTien(ttdt, hopDong);

                //Display the total amount in textbox9
                textBox9.Text = total.ToString();
            }


        }


    }
}
