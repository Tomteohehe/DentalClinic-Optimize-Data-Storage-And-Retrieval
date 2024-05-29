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
    public partial class adminPanel : Form
    {
        public string id;
        public adminPanel(string accID)
        {
            InitializeComponent();
            id = accID;
            label1.Text = id;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kehoachdt kehoachdt = new kehoachdt();
            kehoachdt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lichhenPanel lichhenPanel = new lichhenPanel(id);
            lichhenPanel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            patientForm box = new patientForm(id);
            box.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            doctorForm doc = new doctorForm(id);
            doc.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            receptionForm repPan = new receptionForm(id);
            repPan.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ThuocPanel thuocpan = new ThuocPanel(id);
            thuocpan.Show();
        }
    }
}
