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
using System.Xml;

namespace csdlnc
{
    public partial class patientForm : Form
    {
        string id_qtv;
        string id_Hoso;
        string currID;
        string id_thanhtoan;
        DateTime ngaygd;
        string nguoitt;
        int tiendatra;
        string loaitt;
        string ghichu;

        public patientForm(string accID)
        {
            InitializeComponent();
            gridInit("");
            string id = accID;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            dataGridView2.SelectionChanged += DataGridView2_SelectionChanged;
            dataGridView3.SelectionChanged += DataGridView3_SelectionChanged;
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
                    // Access the value of the "TenThuoc" column
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


        private void DataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Get data from the selected row
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                // Assuming you have a thuoc object associated with each row
                DataRowView dataRow = selectedRow.DataBoundItem as DataRowView;

                // Access the properties of the selected thuoc object
                if (dataRow != null)
                {
                    // Access the value of the "TenThuoc" column
                    string ID_BenhNhan = dataRow["ID_BenhNhan"].ToString();
                    string Hoten = dataRow["HoTen"].ToString();
                    string Tinhtrang = dataRow["ThongTinTongQuanSK"].ToString();
                    string ChiDinh = dataRow["GhiChuChongChiDinhThuoc"].ToString();
                    id_Hoso = dataRow["ID_HoSo"].ToString();

                    // Do something with the data
                    textBox12.Text = ID_BenhNhan;
                    textBox8.Text = Hoten;
                    textBox10.Text = Tinhtrang;
                    textBox11.Text = ChiDinh;


                }
            }
        }


        private void DataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                // Get data from the selected row
                DataGridViewRow selectedRow = dataGridView3.SelectedRows[0];

                // Assuming you have a thuoc object associated with each row
                DataRowView dataRow = selectedRow.DataBoundItem as DataRowView;

                // Access the properties of the selected thuoc object
                if (dataRow != null)
                {
                    // Access the value of the "TenThuoc" column
                    string ID_BenhNhan = dataRow["ID_TaiKhoan"].ToString();
                    id_thanhtoan = dataRow["ID_ThanhToan"].ToString();
                    string Hoten = dataRow["HoTen"].ToString();
                    nguoitt = dataRow["NguoiThanhToan"].ToString();
                    loaitt = dataRow["LoaiThanhToan"].ToString();
                    ghichu = dataRow["GhiChu"].ToString();
                    string tongtien = dataRow["TongTien"].ToString();
                    ngaygd = (DateTime)dataRow["NgayGiaoDich"];
                    id_Hoso = dataRow["ID_HoSo"].ToString();
                    tiendatra = (int)dataRow["TienDaTra"];

                    textBox14.Text = id_Hoso;
                    textBox15.Text = ID_BenhNhan;
                    textBox16.Text = Hoten;
                    textBox17.Text = nguoitt;
                    textBox18.Text = loaitt;
                    textBox19.Text = ghichu;
                    textBox21.Text = tongtien;
                    dateTimePicker2.Value = ngaygd;
                }
            }
        }



        public void gridInit(string query)
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM TaiKhoan WHERE TypeTaiKhoan = 'BN' AND (HoTen LIKE @query OR ID_TaiKhoan LIKE @query )";
            cmd.Parameters.AddWithValue("@query", query + "%");
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        public void gridInit2(string query)
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT ID_HoSo, ThongTinTongQuanSK, GhiChuChongChiDinhThuoc, ID_BenhNhan, SDT, HoTen FROM TaiKhoan, HoSoBenhNhan WHERE ID_BenhNhan = ID_TaiKhoan AND (ID_HoSo LIKE @query OR ID_TaiKhoan LIKE @query )";
            cmd.Parameters.AddWithValue("@query", query + "%");
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        public void gridInit3(string query)
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT tt.ID_ThanhToan, tt.ID_HoSo, tk.ID_TaiKhoan , tk.HoTen, tt.NgayGiaoDich, tt.NguoiThanhToan, tt.LoaiThanhToan, tt.GhiChu, tt.TongTien, tt.TienDaTra, tt.TienThoi FROM TaiKhoan tk,ThongTinChiTietThanhToan tt, HoSoBenhNhan hs WHERE tk.ID_TaiKhoan = hs.ID_BenhNhan AND tt.ID_HoSo = hs.ID_HoSo  AND   (tk.ID_TaiKhoan LIKE @query OR hs.ID_HoSo LIKE @query )";
            cmd.Parameters.AddWithValue("@query", query + "%");
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            gridInit2("");
        }

        private void button1_Click_1(object sender, EventArgs e)
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
            MessageBox.Show("Cap nhat thong tin benh nhan thanh cong");
            gridInit(textBox9.Text);
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
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
            cmd.Parameters.Add("TypeTaiKhoan", SqlDbType.NVarChar).Value = "BN";

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
            MessageBox.Show("Tao moi benh nhan thanh cong");
            gridInit(textBox9.Text);
            con.Close();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            gridInit(textBox9.Text);
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            gridInit2(textBox13.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gridInit2(textBox13.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("P_UPDATE_HOSOBENHNHAN", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ID_HoSo", SqlDbType.NVarChar).Value = id_Hoso;
            cmd.Parameters.Add("ThongTinTongQuanSK", SqlDbType.NVarChar).Value = textBox10.Text;
            cmd.Parameters.Add("GhiChuChongChiDinhThuoc", SqlDbType.NVarChar).Value = textBox11.Text;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Cap Nhat Ho So thanh cong");
            gridInit2(textBox13.Text);
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("P_CREATE_HOSOBENHNHAN", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ID_BenhNhan", SqlDbType.NVarChar).Value = textBox12.Text;
            cmd.Parameters.Add("ThongTinTongQuanSK", SqlDbType.NVarChar).Value = textBox10.Text;
            cmd.Parameters.Add("GhiChuChongChiDinhThuoc", SqlDbType.NVarChar).Value = textBox11.Text;


            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Tao Ho So thanh cong");
            gridInit2(textBox13.Text);
            con.Close();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

   

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            gridInit3(textBox20.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("P_UPDATE_CHITIET", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ID_ThanhToan", SqlDbType.NVarChar).Value = id_thanhtoan;
            cmd.Parameters.Add("NgayGiaoDich", SqlDbType.DateTime).Value = dateTimePicker2.Value;
            cmd.Parameters.Add("NguoiThanhToan", SqlDbType.NVarChar).Value = textBox17.Text;
            cmd.Parameters.Add("LoaiThanhToan", SqlDbType.NVarChar).Value = textBox18.Text;
            cmd.Parameters.Add("TienDaTra", SqlDbType.Int).Value = tiendatra;
            cmd.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value = textBox19.Text;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("CAp nhat thanh cong");
            gridInit3(textBox20.Text);
            con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("P_CREATE_CHITIET", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ID_HoSo", SqlDbType.NVarChar).Value = textBox14.Text;
            cmd.Parameters.Add("NgayGiaoDich", SqlDbType.DateTime).Value = dateTimePicker2.Value;
            cmd.Parameters.Add("NguoiThanhToan", SqlDbType.NVarChar).Value = textBox17.Text;
            cmd.Parameters.Add("LoaiThanhToan", SqlDbType.NVarChar).Value = textBox18.Text;
            cmd.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value = textBox19.Text;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Tao thanh toan thanh cong");
            gridInit3(textBox20.Text);
            con.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            checkout ttform = new checkout(id_thanhtoan, ngaygd, nguoitt, loaitt, ghichu);
            ttform.Show();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select tk.HoTen, tk.ID_TaiKhoan FROM HoSoBenhNhan hs, TaiKhoan tk where hs.ID_BenhNhan = tk.ID_TaiKhoan and ID_HoSo = @query";
            cmd.Parameters.AddWithValue("@query", textBox14.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox16.Text = reader.GetString(0);
                textBox15.Text = reader.GetString(1);
            }
           con.Close();
        }
    }
}
