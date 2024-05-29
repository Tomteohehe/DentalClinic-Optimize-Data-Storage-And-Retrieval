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
    public partial class dentishAppointment : Form
    {
        string ID, b;
        DateTime ThoiGianHen;
        public dentishAppointment(string id)
        {
            ID = id;
            InitializeComponent();
            init(ID);
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }
        public dentishAppointment(string id, string boo1)
        {
            b = boo1;
            ID = id;
            InitializeComponent();
            init(ID);
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }
        
        void init(string query)
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM LichBacSi where ID_NhaSi = @id";
            cmd.Parameters.AddWithValue("@id", query);
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

                    ThoiGianHen = (DateTime)dataRow["ThoiGianTrong"];
                    // Do something with the data

                    dateTimePicker1.Value = ThoiGianHen;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (b=="!NS") MessageBox.Show("Chuc nang nay chi dung cho Nha Si!");
            else
            {
                string connectionString = Program.sqlcon;
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("P_CREATE_LICHBACSI", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("ID_NhaSi", SqlDbType.VarChar).Value = ID;
                cmd.Parameters.Add("ThoiGianTrong", SqlDbType.DateTime).Value = dateTimePicker1.Value;

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
                MessageBox.Show("Them lich thanh cong");
                init(ID);
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (b == "!NS") MessageBox.Show("Chuc nang nay chi dung cho Nha Si!");
            else
            {
                string connectionString = Program.sqlcon;
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("P_UPDATE_LICHBACSI", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("ID_NhaSi", SqlDbType.VarChar).Value = ID;
                cmd.Parameters.Add("CurThoiGianTrong", SqlDbType.DateTime).Value = ThoiGianHen;
                cmd.Parameters.Add("NewThoiGianTrong", SqlDbType.DateTime).Value = dateTimePicker1.Value;

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
                MessageBox.Show("Update lich thanh cong");
                init(ID);
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (b == "!NS") MessageBox.Show("Chuc nang nay chi dung cho Nha Si!");
            else
            {
                string connectionString = Program.sqlcon;
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("P_DELETE_LICHBACSI", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("ID_NhaSi", SqlDbType.VarChar).Value = ID;

                cmd.Parameters.Add("ThoiGianTrong", SqlDbType.DateTime).Value = dateTimePicker1.Value;

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
                MessageBox.Show("Xoa lich thanh cong");
                init(ID);
                con.Close();
            }
        }
    }
}
