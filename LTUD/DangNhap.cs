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


namespace LTUD
{
    public partial class DangNhap : Form
    {
        SqlConnection conn = new SqlConnection();
        Ham ham = new Ham();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void dn_Click(object sender, EventArgs e)
        {
            string tendn = manv.Text;
            string passdn = this.passdn.Text;
            string sql_dn = "Select MaNV , Password from USERS where MaNV = '" + tendn + "' and Password = '" + passdn + "'";
            SqlCommand comd = new SqlCommand(sql_dn, conn);
            SqlDataReader reader = comd.ExecuteReader();
            if (reader.Read())
            {
                TrangChu trangchu = new TrangChu(tendn);
                trangchu.Show();
            }
            else
            {
                MessageBox.Show("Dang Nhap That Bai");
            }
            reader.Close();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            ham.Ketnoi(conn);
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                passdn.Focus();
            }
        }

        private void passdn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dn.Focus();
            }
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked == true)
            {
                passdn.UseSystemPasswordChar = false;
            }
            else
            {
                passdn.UseSystemPasswordChar = true;
            }
        }
    }
}