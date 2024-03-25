using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LTUD
{
    public partial class TrangChu : Form
    {
        SqlConnection conn = new SqlConnection();
        Ham ham = new Ham();
        public String userlogin;

        public TrangChu(string tendn)
        {
            InitializeComponent();
            label_hello.Text = tendn;
            userlogin = tendn;
        }

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(childForm);
            mainpanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            ham.Ketnoi(conn);
        }

        private void trasua_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TraSua());
            label1.Text = trasua.Text;
        }

        private void doanvat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DoAnVat());
            label1.Text = doanvat.Text;
        }

        private void hoadon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HoaDon(userlogin));
            label1.Text = hoadon.Text;
        }

        private void thongtinnhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhanVien());
            label1.Text = thongtinnhanvien.Text;
        }

        private void thongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKe());
            label1.Text = thongke.Text;
        }
    }
}
