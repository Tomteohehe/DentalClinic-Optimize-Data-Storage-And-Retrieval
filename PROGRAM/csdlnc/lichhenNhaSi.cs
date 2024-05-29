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
    public partial class lichhenNhaSi : Form
    {
        public string ID;
        string ID_LichHen;
        public lichhenNhaSi(string id)
        {
            ID = id;
            InitializeComponent();

            gridInit(ID);
        }
        private void gridInit(string query)

        {

            string connectionString = Program.sqlcon;

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT ID_LichHen, ThoiGianHen, TinhTrang, ID_BenhNhan, ID_NhaSi, ID_PhongKham, ID_TroKham FROM LichHen where ID_NhaSi = @query AND ID_BenhNhan LIKE @query";
            cmd.Parameters.AddWithValue("@query", query + "%" );
            
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }


     

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            gridInit(textBox2.Text);
        }
    }
}
