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

namespace csdlnc
{
    public partial class patient_khdt : Form
    {
        string ID;
        public patient_khdt(string id)
        {
            ID = id;
            InitializeComponent();
            getData(ID);
        }
        void getData(string id)
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM KeHoachDieuTri WHERE  ( ID_HoSo = @query)";
            cmd.Parameters.AddWithValue("@query", id );
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
