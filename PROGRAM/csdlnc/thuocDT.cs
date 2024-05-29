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
    public partial class thuocDT : Form
    {
        public thuocDT(string idct, string idhs)
        {


            InitializeComponent();
            loadList5();


            init(idct, idhs);
        }

        void init(string idct, string idhs)
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT ID_KHDieuTri FROM KeHoachDieuTri where ID_ThanhToan = @idtt AND ID_HoSo = @idhs";
            cmd.Parameters.AddWithValue("@idtt", idct);
            cmd.Parameters.AddWithValue("@idhs", idhs);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox5.Text = reader.GetString(0);
            }
            con.Close();

        }

        private void loadList5()
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT  ID_Thuoc from Thuoc ";
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            comboBox7.DataSource = dt;
            comboBox7.DisplayMember = "ID_Thuoc";
            comboBox7.ValueMember = "ID_Thuoc";

            con.Close(); // Close the connection
        }






        //CT00999989
        private void button3_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=10.211.55.2;Initial Catalog=QLPKNKHOA;User ID=sa;Password=VeryStr0ngP@ssw0rd;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("P_CREATE_DONTHUOC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ID_KHDieuTri", SqlDbType.VarChar).Value = textBox5.Text;
            cmd.Parameters.Add("ID_Thuoc", SqlDbType.VarChar).Value = comboBox7.Text;
            cmd.Parameters.Add("SoLuongThuoc", SqlDbType.Int).Value = textBox1.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Them thuoc thanh cong");
        }
    }
}
