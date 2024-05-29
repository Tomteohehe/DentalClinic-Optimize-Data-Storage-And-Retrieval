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
    public partial class lichhenPanel : Form
    {
        public string ID;
        string ID_LichHen;
        public lichhenPanel(string id)
        {
            ID = id;
            InitializeComponent();
        
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            listLoad1();
            listLoad2();
        }


        private void gridInit(string query)

        {

            string connectionString = Program.sqlcon;

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT ID_LichHen, ThoiGianHen, TinhTrang, ID_BenhNhan, ID_NhaSi, ID_PhongKham, ID_TroKham FROM LichHen  ";
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
                    ID_LichHen = dataRow["ID_LichHen"].ToString();
                    string ID_NhaSi = dataRow["ID_NhaSi"].ToString();
                    string ID_BenhNhan = dataRow["ID_BenhNhan"].ToString();
                    string ID_PhongKham = dataRow["ID_PhongKham"].ToString();
                    string ID_TroKham = dataRow["ID_TroKham"].ToString();
                    string TinhTrang = dataRow["TinhTrang"].ToString();
                    DateTime ThoiGianHen = (DateTime)dataRow["ThoiGianHen"];
                    // Do something with the data
                    textBox2.Text = ID_BenhNhan;
                    comboBox1.Text = ID_NhaSi;
                    comboBox2.Text = ID_TroKham;
                    comboBox3.Text = ID_PhongKham;
                    textBox5.Text = TinhTrang;

                    dateTimePicker1.Value = ThoiGianHen;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("P_UPDATE_LICHHEN", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ID_BenhNhan", SqlDbType.NVarChar).Value = textBox2.Text;
            cmd.Parameters.Add("ID_NhaSi", SqlDbType.NVarChar).Value = comboBox1.Text;
            cmd.Parameters.Add("ID_TroKham", SqlDbType.NVarChar).Value = comboBox2.Text;
            cmd.Parameters.Add("ID_PhongKham", SqlDbType.Char).Value = comboBox3.Text;
            cmd.Parameters.Add("TinhTrang", SqlDbType.Char).Value = textBox5.Text;
            cmd.Parameters.Add("ID_LichHen", SqlDbType.Char).Value = ID_LichHen;
            cmd.Parameters.Add("ThoiGianHen", SqlDbType.DateTime).Value = dateTimePicker1.Text.ToString();
            cmd.Parameters.Add("ID_NV", SqlDbType.VarChar).Value = ID;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return;
            }
            MessageBox.Show("Update lich hen thanh cong");
            gridInit("");
            con.Close();
        }



        private void listLoad1()
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT  ID_TaiKhoan from TaiKhoan where TypeTaiKhoan = 'NS'";
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "ID_TaiKhoan";
            comboBox1.ValueMember = "ID_TaiKhoan";
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "ID_TaiKhoan";
            comboBox2.ValueMember = "ID_TaiKhoan";

            con.Close(); // Close the connection
        }

        private void listLoad2()
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT  ID_PhongKham from PhongKham ";
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "ID_PhongKham";
            comboBox3.ValueMember = "ID_PhongKham";

            con.Close(); // Close the connection
        }
        private void lichhenPanel_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "DELETE FROM LichHen where ID_LichHen = @query  ";
            cmd.Parameters.AddWithValue("@query", ID_LichHen);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xoa lich hen thanh cong");
            gridInit("");

        }



        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("P_THEM_LICHHEN", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ID_BenhNhan", SqlDbType.NVarChar).Value = textBox2.Text.ToString();
            cmd.Parameters.Add("ID_NhaSi", SqlDbType.NVarChar).Value = comboBox1.Text.ToString();
            cmd.Parameters.Add("ID_TroKham", SqlDbType.NVarChar).Value = comboBox2.Text.ToString();
            cmd.Parameters.Add("ID_PhongKham", SqlDbType.Char).Value = comboBox3.Text.ToString();
            cmd.Parameters.Add("TinhTrang", SqlDbType.Char).Value = textBox5.Text.ToString();
            cmd.Parameters.Add("ThoiGianHen", SqlDbType.DateTime).Value = dateTimePicker1.Text.ToString();
            cmd.Parameters.Add("ID_NV", SqlDbType.VarChar).Value = ID;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return;
            }
            MessageBox.Show("Tao lich hen thanh cong");
            gridInit("");
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            gridInit(textBox1.Text);
        }
    }
}
