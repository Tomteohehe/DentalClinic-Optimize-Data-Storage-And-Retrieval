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
    public partial class accountCreate : Form
    {
        string accid;
        string currid;
        public accountCreate(string id)
        {
            InitializeComponent();
            accid = id;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool success = false;
            string connectionString = "Data Source=10.211.55.2;Initial Catalog=QLPKNKHOA;User ID=sa;Password=VeryStr0ngP@ssw0rd;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("P_CREATE_ACCOUNT", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("HoTen", SqlDbType.NVarChar).Value = textBox1.Text.ToString();
            cmd.Parameters.Add("TenTaiKhoan", SqlDbType.NVarChar).Value = textBox2.Text.ToString();
            cmd.Parameters.Add("MatKhau", SqlDbType.NVarChar).Value = textBox3.Text.ToString();
            cmd.Parameters.Add("TypeTaiKhoan", SqlDbType.Char).Value = "BN";
            cmd.Parameters.Add("DiaChi", SqlDbType.Char).Value = textBox5.Text.ToString();
            cmd.Parameters.Add("Email", SqlDbType.Char).Value = textBox6.Text.ToString();
            cmd.Parameters.Add("GioiTinh", SqlDbType.Char).Value = textBox7.Text.ToString();
            cmd.Parameters.Add("SDT", SqlDbType.Char).Value = textBox8.Text.ToString();
            cmd.Parameters.Add("NgaySinh", SqlDbType.DateTime).Value = dateTimePicker1.Text.ToString();
            cmd.Parameters.Add("ID_QTV", SqlDbType.VarChar).Value = "admin";
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) { success = true; }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (success) MessageBox.Show("Success");
            con.Close();
        }
    }
}
