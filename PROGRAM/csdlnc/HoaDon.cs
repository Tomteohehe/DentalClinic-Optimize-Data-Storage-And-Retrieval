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

namespace csdlnc
{
    public partial class HoaDon : Form
    {

        public HoaDon()
        {
            InitializeComponent();
        }


        public void getData(string query)
        {
            string connectionString = "Data Source=10.211.55.2;Initial Catalog=QLPKNKHOA;User ID=sa;Password=VeryStr0ngP@ssw0rd;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select NguoiThanhToan, LoaiThanhToan, GhiChu,TongTien  from ThongTinChiTietThanhToan WhERE ID_HoSo = @query";
            cmd.Parameters.AddWithValue("@query", query);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr.GetString(0);
                textBox3.Text = dr.GetString(1);
                textBox4.Text = dr.GetString(2);
                textBox5.Text = dr.GetInt32(3).ToString();
            } 
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            getData(textBox1.Text.ToString());
        }
    }
}
