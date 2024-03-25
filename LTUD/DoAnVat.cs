using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD
{
    public partial class DoAnVat : Form
    {
        SqlConnection conn = new SqlConnection();
        Ham ham = new Ham();

        public DoAnVat()
        {
            InitializeComponent();
        }

        private void DoAnVat_Load(object sender, EventArgs e)
        {
            ham.Ketnoi(conn);
            string link = "D:\\BaiTap_CTU\\LTUD\\HinhAnh\\banhtrangtron.jpg";
            hinhDAV.Image = new Bitmap(link);
            ham.HienThiDLDG(dataGVDAV, "SELECT * FROM DOANVAT", conn);
        }

        private void dataGVDAV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_them.Enabled = false;
            btn_luu.Enabled = false;

            maDAV.Text = dataGVDAV.Rows[e.RowIndex].Cells[0].Value.ToString();
            tenDAV.Text = dataGVDAV.Rows[e.RowIndex].Cells[1].Value.ToString();
            sizeDAV.Text = dataGVDAV.Rows[e.RowIndex].Cells[2].Value.ToString();
            tpDAV.Text = dataGVDAV.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void loadhinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult result = open.ShowDialog();
            if (result == DialogResult.OK)
            {
                hinhDAV.Image = new Bitmap(open.FileName);
                hinhDAV.Text = open.FileName;
            }
        }

        public void LoadDTDV()
        {
            ham.HienThiDLDG(dataGVDAV, "SELECT * FROM DOANVAT WHERE TenDAV LIKE N'%" + searchDAV.Text + "%'", conn);
        }

        private void searchDAV_TextChanged(object sender, EventArgs e)
        {
            LoadDTDV();
        }

        private void huyDAV_Click(object sender, EventArgs e)
        {
            searchDAV.ResetText();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string malonnhat = "SELECT MAX(SUBSTRING(MaDAV, 4, 3)) FROM DOANVAT";
            SqlCommand comd = new SqlCommand(malonnhat, conn);
            SqlDataReader reader = comd.ExecuteReader();

            if (reader.Read())
            {
                int max = Convert.ToInt32(reader.GetValue(0).ToString()) + 1;
                if (max < 10)
                {
                    maDAV.Text = "DAV0" + max;
                }
                else
                {
                    maDAV.Text = "DAV" + max;
                }
                maDAV.Enabled = false;
            }
            reader.Close();

            btn_sua.Enabled = false;
            btn_luu.Enabled = true;

            tenDAV.Text = "";
            sizeDAV.Text = "Chọn size";
            tpDAV.Text = "";
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE DOANVAT SET TenDAV = N'" + tenDAV.Text + "', Size = '" + sizeDAV.Text + "', Topping = N'" + tpDAV.Text + "'  WHERE MaDAV ='" + maDAV.Text + "'";
            SqlCommand comd = new SqlCommand(sql, conn);
            ham.CapNhat(sql, conn);
            ham.HienThiDLDG(dataGVDAV, "SELECT * FROM DOANVAT", conn);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM DOANVAT WHERE MaDAV = '" + maDAV.Text + "'";
            SqlCommand comd = new SqlCommand(sql, conn);
            ham.CapNhat(sql, conn);
            ham.HienThiDLDG(dataGVDAV, "SELECT * FROM DOANVAT", conn);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string ma = maDAV.Text;
            string ten = tenDAV.Text;

            string sql = "INSERT INTO DOANVAT(madav,tendav,size,topping,hinhanh) VALUES ('" + ma + "', N'" + ten + "', '" + sizeDAV.Text + "', N'" + tpDAV.Text + "', '" + Path.GetFileName(hinhDAV.Text) + "')";
            SqlCommand comd = new SqlCommand(sql, conn);
            comd.ExecuteNonQuery();
            ham.HienThiDLDG(dataGVDAV, "SELECT * FROM DOANVAT", conn);
        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
