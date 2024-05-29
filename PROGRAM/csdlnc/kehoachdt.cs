using System;
using System.Collections;
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
    public partial class kehoachdt : Form
    {
        string idkh;
        public kehoachdt()
        {
            InitializeComponent();
            gridInit("");
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;

            // Add TextChanged event handler for the TextBox



            // Load initial data into ComboBox

            loadList2();
            loadList3();
            loadList4();

        }




        private void loadList2()
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT ID_TaiKhoan From TaiKhoan where TypeTaiKhoan = 'NS' ";
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "ID_TaiKhoan";
            comboBox2.ValueMember = "ID_TaiKhoan";
            comboBox4.DataSource = dt;
            comboBox4.DisplayMember = "ID_TaiKhoan";
            comboBox4.ValueMember = "ID_TaiKhoan";
            con.Close(); // Close the connection
        }


        private void loadList3()
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT ID_DanhMuc From DanhMucDieuTri ";
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "ID_DanhMuc";
            comboBox3.ValueMember = "ID_DanhMuc";
            con.Close(); // Close the connection
        }


        private void loadList4()
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT ID_ThanhToan From ThongTinChiTietThanhToan ";
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            comboBox5.DataSource = dt;
            comboBox5.DisplayMember = "ID_ThanhToan";
            comboBox5.ValueMember = "ID_ThanhToan";
            con.Close(); // Close the connection
        }





        private void gridInit(string query)
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM KeHoachDieuTri WHERE  ( ID_KHDieuTri LIKE @query OR ID_ThanhToan LIKE @query OR ID_HoSo LIKE @query)";

            cmd.Parameters.AddWithValue("@query", query + "%");
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }


     

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get data from the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Assuming you have a thuoc object associated with each row
                DataRowView dataRow = selectedRow.DataBoundItem as DataRowView;

                // Access the properties of the selected thuoc object
                if (dataRow != null)
                {
                    // Access the value of the "TenThuoc" column


                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("P_CREATE_KHDIEUTRI", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("MoTa", SqlDbType.NVarChar).Value = textBox3.Text;
            cmd.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value = textBox2.Text;
            cmd.Parameters.Add("TrangThai", SqlDbType.NVarChar).Value = textBox4.Text;
            cmd.Parameters.Add("ID_HoSo", SqlDbType.NVarChar).Value = textBox5.Text;
            cmd.Parameters.Add("ID_BacSiThucHien", SqlDbType.NVarChar).Value = comboBox2.Text;
            cmd.Parameters.Add("ID_BacSiTroKham", SqlDbType.NVarChar).Value = comboBox4.Text;
            cmd.Parameters.Add("ID_DanhMuc", SqlDbType.NVarChar).Value = comboBox3.Text;
            cmd.Parameters.Add("ID_ThanhToan", SqlDbType.NVarChar).Value = comboBox5.Text;
            cmd.Parameters.Add("NgayDieuTri", SqlDbType.DateTime).Value = dateTimePicker1.Value;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return;
            }
            MessageBox.Show("Tao ke hoach thanh cong");
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            gridInit(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rangdt rd = new rangdt(comboBox5.Text, textBox5.Text);
            rd.Show();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT ID_HoSo From ThongTinChiTietThanhToan where ID_ThanhToan = @query";
            cmd.Parameters.AddWithValue("@query", comboBox5.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox5.Text = reader.GetString(0);
            }

            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            thuocDT tkh = new thuocDT(comboBox5.Text, textBox5.Text);
            tkh.Show();
        }
    }
}
