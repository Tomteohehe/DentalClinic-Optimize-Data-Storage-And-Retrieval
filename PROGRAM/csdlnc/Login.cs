using System.Data;
using System.Data.SqlClient;


namespace csdlnc
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT ID_TaiKhoan, TypeTaiKhoan FROM [TaiKhoan] WHERE TenTaiKhoan = @username AND MatKhau = @password";
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            string accId = "", accType = "";
            while (reader.Read())
            {
                accId = reader.GetString(0);
                accType = reader.GetString(1);
            }
            if (accType == "QT")
            {
                adminPanel adminPanel = new adminPanel(accId);
                adminPanel.Show();
            }
            else if (accType == "NV")
            {
                receptionPanel recp = new receptionPanel(accId);
                recp.Show();
            }
            else if (accType == "NS")
            {
                dentisPanel docpan = new dentisPanel(accId);
                docpan.Show();
            }
            else if (accType == "BN")
            {
                patientPanel patientPanel = new patientPanel(accId);
                patientPanel.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials, please try again");
            }
            Hide();
            con.Close();
        }

    
    }
}
