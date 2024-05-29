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
    public partial class patientPanel : Form
    {
        string id;
        public patientPanel(string accID)
        {
            InitializeComponent();
            id = accID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            patient_khdt khdt = new patient_khdt(getIDHS(id));
            khdt.Show();
        }

        string getIDHS(string accID)
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT ID_HoSo FROM HoSoBenhNhan WHERE  ( ID_BenhNhan = @query)";

            cmd.Parameters.AddWithValue("@query", accID);
            SqlDataReader reader = cmd.ExecuteReader();
            string id = "";
            while (reader.Read())
            {
                id = reader.GetString(0);
            }
            con.Close();
            return id;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            patientcttt p = new patientcttt(getIDHS(id));
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patientProfile pro = new patientProfile(id);
            pro.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            patientlh plh = new patientlh(id);
            plh.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
