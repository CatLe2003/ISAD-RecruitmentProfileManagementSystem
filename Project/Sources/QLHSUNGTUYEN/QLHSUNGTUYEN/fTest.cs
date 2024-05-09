using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSUNGTUYEN
{
    public partial class fTest : Form
    {
        public fTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strCon = "Data Source=LAPTOP-MA9ME0JB; Initial Catalog=QLHSUngTuyen;Integrated Security=True;";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string query = "select * from nhanvien";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string output = reader.GetValue(0) + "-" + reader.GetValue(1);
                MessageBox.Show(output);
            }
        }

        private void fTest_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // reset lại csdl được hiển thị
            // load toàn bộ danh sách phiếu đăng ký quảng cáo của doanh nghiệp
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter()
            {
                key = "@madn",
                value = "4"
            });
            parameters.Add(new CustomParameter()
            {
                key = "@keyword",
                value = ""
            });

            dataGridView1.DataSource = new Database().SelectData("XemPhieuDKQC_DoanhNghiep", parameters);

        }
    }
}
