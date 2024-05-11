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

        public fLapHopDong()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fLapHopDong_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //btn_Ghi
        {
            
            try
            {
                //Retrieve values from the form's controls
                nhanVien.MaNV = int.Parse(label2.Text);
                doanhNghiep.MaDN = int.Parse(textBox5.Text);
                hopDong.NoiDung = textBox6.Text;
                hopDong.SoDotTT = int.Parse(textBox8.Text);
                hopDong.SoTienTT = int.Parse(textBox9.Text);
                hopDong.UuDai = int.Parse(textBox10.Text);

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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //btn_TinhTien
        {
           //Retrieve values from the form's controls
           ttdt.MaDT = int.Parse(textBox1.Text); 
           hopDong.UuDai = int.Parse(textBox10.Text);

           //Call the method in the business logic layer to calculate the total amount
           int total = hopDong.TinhTien(ttdt, hopDong);

           //Display the total amount in textbox9
           textBox9.Text = total.ToString();
        }

       
    }
}
