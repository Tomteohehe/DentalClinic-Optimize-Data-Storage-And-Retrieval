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
    public partial class ThuocPanel : Form
    {
        string ID_Medic;
        string id_qtv;
        public ThuocPanel(string id_nv)
        {
            InitializeComponent();
            gridInit("");
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            id_qtv = id_nv;
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
                    ID_Medic = dataRow["ID_Thuoc"].ToString();
                    string tenThuoc = dataRow["TenThuoc"].ToString();
                    string DonVi = dataRow["DonViTinh"].ToString();
                    string ChiDinh = dataRow["ChiDinh"].ToString();
                    string SoLuong = dataRow["SoLuongTonKho"].ToString();
                    string DonGia = dataRow["DonGia"].ToString();
                    DateTime ngay = (DateTime)dataRow["NgayHetHan"];
                    // Do something with the data
                    textBox1.Text = tenThuoc;
                    textBox2.Text = DonVi;
                    textBox3.Text = ChiDinh;
                    textBox4.Text = SoLuong;
                    textBox5.Text = DonGia;
                    dateTimePicker1.Value = ngay;
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
            cmd.CommandText = "SELECT ID_Thuoc, ID_QTV, TenThuoc, DonViTinh, ChiDinh, SoLuongTonKho, NgayHetHan, DonGia FROM Thuoc WHERE (TenThuoc LIKE @query or ID_Thuoc LIKE @query)";
            cmd.Parameters.AddWithValue("@query", query + "%");
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gridInit(textBox9.Text);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            gridInit(textBox9.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("P_UPDATE_THUOC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ID_Thuoc", SqlDbType.NVarChar).Value = ID_Medic;
            cmd.Parameters.Add("TenThuoc", SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("DonViTinh", SqlDbType.NVarChar).Value = textBox2.Text;
            cmd.Parameters.Add("ChiDinh", SqlDbType.NVarChar).Value = textBox3.Text;
            cmd.Parameters.Add("SoLuongTonKho", SqlDbType.NVarChar).Value = textBox4.Text;
            cmd.Parameters.Add("DonGia", SqlDbType.NVarChar).Value = textBox5.Text;
            cmd.Parameters.Add("NgayHetHan", SqlDbType.DateTime).Value = dateTimePicker1.Value;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Cap nhat thong tin thuoc thanh cong");

            con.Close();
            gridInit("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_DELETE_THUOC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ID_Thuoc", SqlDbType.NVarChar).Value = ID_Medic;
      
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Xoa thuoc thanh cong");

            con.Close();
            gridInit("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("P_CREATE_THUOC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ID_Thuoc", SqlDbType.NVarChar).Value = ID_Medic;
            cmd.Parameters.Add("TenThuoc", SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("DonViTinh", SqlDbType.NVarChar).Value = textBox2.Text;
            cmd.Parameters.Add("ChiDinh", SqlDbType.NVarChar).Value = textBox3.Text;
            cmd.Parameters.Add("SoLuongTonKho", SqlDbType.NVarChar).Value = textBox4.Text;
            cmd.Parameters.Add("DonGia", SqlDbType.NVarChar).Value = textBox5.Text;
            cmd.Parameters.Add("NgayHetHan", SqlDbType.DateTime).Value = dateTimePicker1.Value;
            cmd.Parameters.Add("ID_QTV", SqlDbType.NVarChar).Value = id_qtv;

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

            MessageBox.Show("Tao thuoc thanh cong");

            con.Close();
            gridInit("");
        }
    }
}
