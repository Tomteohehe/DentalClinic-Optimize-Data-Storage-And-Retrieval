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
    public partial class doctorForm : Form
    {
        string id_qtv;

        string currID;
        public doctorForm(string accID)
        {
            InitializeComponent();
            gridInit("");
            string id = accID;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            id_qtv = accID;
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
                   
                    currID = dataRow["ID_TaiKhoan"].ToString();
                    string Hoten = dataRow["HoTen"].ToString();
                    string Diachi = dataRow["DiaChi"].ToString();
                    string SDT = dataRow["SDT"].ToString();
                    string email = dataRow["Email"].ToString();
                    DateTime NgaySinh = (DateTime)dataRow["NgaySinh"];
                    string username = dataRow["TenTaiKhoan"].ToString();
                    string pass = dataRow["MatKhau"].ToString();
                    string sex = dataRow["GioiTinh"].ToString();
                    // Do something with the data
                    textBox1.Text = Hoten;
                    textBox2.Text = Diachi;
                    textBox3.Text = SDT;
                    textBox4.Text = email;
                    textBox5.Text = username;
                    textBox6.Text = pass;
                    textBox7.Text = sex;
                    dateTimePicker1.Value = NgaySinh;
                }
            }
        }

        private void gridInit(string query)
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM TaiKhoan WHERE TypeTaiKhoan = 'NS' AND (HoTen LIKE @query OR SDT LIKE @query OR ID_TaiKhoan LIKE @query )";
            cmd.Parameters.AddWithValue("@query", query + "%");
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!id_qtv.Contains("AD")) MessageBox.Show("Chuc nang nay chi dung cho ADMIN!");
            else
            {
                string connectionString = Program.sqlcon;
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("P_UPDATE_ACCOUNT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("ID_QTV", SqlDbType.NVarChar).Value = id_qtv;
                cmd.Parameters.Add("HoTen", SqlDbType.NVarChar).Value = textBox1.Text;
                cmd.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = textBox2.Text;
                cmd.Parameters.Add("SDT", SqlDbType.NVarChar).Value = textBox3.Text;
                cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = textBox4.Text;
                cmd.Parameters.Add("TenTaiKhoan", SqlDbType.NVarChar).Value = textBox5.Text;
                cmd.Parameters.Add("MatKhau", SqlDbType.NVarChar).Value = textBox6.Text;
                cmd.Parameters.Add("NgaySinh", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                cmd.Parameters.Add("GioiTinh", SqlDbType.NVarChar).Value = textBox7.Text;
                cmd.Parameters.Add("ID_TaiKhoan", SqlDbType.NVarChar).Value = currID;
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
                MessageBox.Show("Cap nhat thong tin nha si thanh cong");
                gridInit(textBox9.Text);
                con.Close();
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            gridInit(textBox9.Text);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (!id_qtv.Contains("AD")) MessageBox.Show("Chuc nang nay chi dung cho ADMIN!");
            else
            {
                string connectionString = Program.sqlcon;
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("P_CREATE_ACCOUNT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("ID_QTV", SqlDbType.NVarChar).Value = id_qtv;
                cmd.Parameters.Add("HoTen", SqlDbType.NVarChar).Value = textBox1.Text;
                cmd.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = textBox2.Text;
                cmd.Parameters.Add("SDT", SqlDbType.NVarChar).Value = textBox3.Text;
                cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = textBox4.Text;
                cmd.Parameters.Add("TenTaiKhoan", SqlDbType.NVarChar).Value = textBox5.Text;
                cmd.Parameters.Add("MatKhau", SqlDbType.NVarChar).Value = textBox6.Text;
                cmd.Parameters.Add("NgaySinh", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                cmd.Parameters.Add("GioiTinh", SqlDbType.NVarChar).Value = textBox7.Text;
                cmd.Parameters.Add("TypeTaiKhoan", SqlDbType.NVarChar).Value = "NS";

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
                MessageBox.Show("Tao moi nha si thanh cong");
                gridInit(textBox9.Text);
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dentishAppointment lich = new dentishAppointment(currID, "!NS");
            lich.Show();
        }
    }
}
