using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QLHSUNGTUYEN.NhanVien.BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLHSUNGTUYEN.NhanVien.Forms
{
    public partial class fLapHopDong : Form
    {
        LapHopDong_Controller lapHopDong = new LapHopDong_Controller();
        DNghiep doanhNghiep = new DNghiep();
        NVien nhanVien = new NVien();
        HopDong hopDong = new HopDong();
        ThongTinDT ttdt = new ThongTinDT();

        public fLapHopDong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //btn_Ghi
        {
            if (textBox1.Text == "" || textBox5.Text == "" ||
            textBox4.Text == "" || textBox3.Text == "" ||
            textBox6.Text == "" || textBox8.Text == "" ||
            textBox9.Text == "" || textBox10.Text == "")
            {
                MessageBox.Show("Lỗi: Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {

                //Retrieve values from the form's controls
                //lapHopDong.MaHD = int.Parse(textBox1.Text);
                //lapHopDong.ID = ""; 
                //nhanVien.MaNV = int.Parse(label2.Text);
                doanhNghiep.MaDN = int.Parse(textBox5.Text);
                hopDong.NgKy = DateTime.Parse(textBox4.Text);
                hopDong.NgHetHan = DateTime.Parse(textBox3.Text);
                hopDong.NoiDung = textBox6.Text;
                hopDong.SoDotTT = int.Parse(textBox8.Text);
                hopDong.SoTienTT = int.Parse(textBox9.Text);
                hopDong.UuDai = int.Parse(textBox10.Text);

                if (checkBox1.Checked)
                {
                    hopDong.TinhTrangKyDuyet = "1";
                }
                else
                {
                    hopDong.TinhTrangKyDuyet = "0";
                }

                //Call the method in the business logic layer to insert the new row
                bool success = lapHopDong.GhiNhanHopDong(nhanVien, doanhNghiep, hopDong);

                if (success) MessageBox.Show("Thêm mới hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Lỗi: Thêm hợp đồng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            //Call the method in the business logic layer to calculate the total amount
            int total = hopDong.TinhTien(ttdt, hopDong);

            //Display the total amount in textbox9
            textBox9.Text = total.ToString();
        }


    }
}
