using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csdlnc
{
    public partial class dentisPanel : Form
    {
        string ID;
        public dentisPanel(string id)
        {
            InitializeComponent();
            ID = id;
            label1.Text = ID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            patientForm patient = new patientForm(ID);
            patient.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dentishAppointment dentishAppointment = new dentishAppointment(ID);
            dentishAppointment.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lichhenNhaSi lichNS = new lichhenNhaSi(ID);
            lichNS.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kehoachdt kdt = new kehoachdt();
            kdt.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
