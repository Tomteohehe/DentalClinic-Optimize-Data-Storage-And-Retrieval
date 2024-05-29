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
    public partial class patientlh : Form
    {
        public patientlh(string id)
        {
            InitializeComponent();
            gridInit(id);
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }
        private void gridInit(string query)

        {

            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT ID_LichHen, ThoiGianHen, TinhTrang, ID_BenhNhan, ID_NhaSi, ID_PhongKham, ID_TroKham FROM LichHen  Where ID_BenhNhan = @query";
            cmd.Parameters.AddWithValue("@query", query);
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
    }
}
