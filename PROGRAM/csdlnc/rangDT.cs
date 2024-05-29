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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace csdlnc
{
    public partial class rangdt : Form
    {

        public rangdt(string idct, string idhs)
        {
            InitializeComponent();
            loadList5();

            loadList7();
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
            cmd.Parameters.AddWithValue ("@idhs", idhs);
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
            cmd.CommandText = "SELECT  r.ID_Rang from Rang r ";
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            comboBox7.DataSource = dt;
            comboBox7.DisplayMember = "ID_Rang";
            comboBox7.ValueMember = "ID_Rang";

            con.Close(); // Close the connection
        }




        private void loadList7()
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT ID_MatRang from MatRang";

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            comboBox8.DataSource = dt;
            comboBox8.DisplayMember = "ID_MatRang";
            comboBox8.ValueMember = "ID_MatRang";

            con.Close(); // Close the connection
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=10.211.55.2;Initial Catalog=QLPKNKHOA;User ID=sa;Password=VeryStr0ngP@ssw0rd;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("P_CREATE_RANGDIEUTRI", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ID_KHDieuTri", SqlDbType.NVarChar).Value = textBox5.Text;
            cmd.Parameters.Add("ID_Rang", SqlDbType.NVarChar).Value = comboBox7.Text;
            cmd.Parameters.Add("ID_MatRang", SqlDbType.NVarChar).Value = comboBox8.Text;
            cmd.ExecuteNonQuery();

            con.Close();
        }

       
    }
}
