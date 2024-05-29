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
    public partial class checkout : Form
    {
        string idtt, nguoitt, loai, ghichu;
        DateTime ngaytt;
        public checkout(string id, DateTime ngay, string nguoitra, string loaitt, string note)
        {
            InitializeComponent();
            init(id);
            idtt = id;
            ngaytt = ngay;
            nguoitt = nguoitra;
            loai = loaitt;
            ghichu = note;
        }

        void init(string query)
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT TongTien FROM ThongTinChiTietThanhToan where ID_ThanhToan = @query";
            cmd.Parameters.AddWithValue("@query", query);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                textBox1.Text = sqlDataReader.GetInt32(0).ToString();
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = Program.sqlcon;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("P_UPDATE_CHITIET", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ID_THanhToan", SqlDbType.NVarChar).Value = idtt;
            cmd.Parameters.Add("NgayGiaoDich", SqlDbType.DateTime).Value = ngaytt;
            cmd.Parameters.Add("NguoiThanhToan", SqlDbType.NVarChar).Value = nguoitt;
            cmd.Parameters.Add("LoaiThanhToan", SqlDbType.NVarChar).Value = loai;
            cmd.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value = ghichu;
            cmd.Parameters.Add("TienDaTra", SqlDbType.Int).Value = textBox2.Text;
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
            MessageBox.Show("Tao Ho So thanh cong");

            con.Close();
        }
    }
}
