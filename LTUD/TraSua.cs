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
    public partial class TraSua : Form
    {
        SqlConnection conn = new SqlConnection();
        Ham ham = new Ham();

        public TraSua()
        {
            InitializeComponent();
        }

        private void TraSua_Load(object sender, EventArgs e)
        {
            ham.Ketnoi(conn);
            string link = "D:\\BaiTap_CTU\\LTUD\\HinhAnh\\trasuamatcha.jpg";
            hinhTS.Image = new Bitmap(link);
            ham.HienThiDLDG(dataGVTS, "SELECT * FROM TRASUA", conn);
        }

        private void DTTraSua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_them.Enabled = false;
            btn_luu.Enabled = false;

            maTS.Text = dataGVTS.Rows[e.RowIndex].Cells[0].Value.ToString();
            tenTS.Text = dataGVTS.Rows[e.RowIndex].Cells[1].Value.ToString();
            sizeTS.Text = dataGVTS.Rows[e.RowIndex].Cells[2].Value.ToString();
            tpTS.Text = dataGVTS.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void loadhinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult result = open.ShowDialog();
            if (result == DialogResult.OK)
            {
                hinhTS.Image = new Bitmap(open.FileName);
                link.Text = open.FileName;
            }
        }

        public void LoadDTDV()
        {
            ham.HienThiDLDG(dataGVTS,"SELECT * FROM TRASUA WHERE TenTS LIKE N'%" + searchTS.Text.Trim() + "%'", conn);
        }
        private void timTS_Click(object sender, EventArgs e)
        {
            LoadDTDV();
        }
        private void huyTS_Click(object sender, EventArgs e)
        {
            searchTS.ResetText();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string malonnhat = "SELECT MAX(SUBSTRING(MaTS, 3, 2)) FROM TRASUA";
            SqlCommand comd = new SqlCommand(malonnhat, conn);
            SqlDataReader reader = comd.ExecuteReader();

            if (reader.Read())
            {
                int max = Convert.ToInt32(reader.GetValue(0).ToString()) + 1;
                if (max < 10)
                {
                    maTS.Text = "TS0" + max;
                }
                else
                {
                    maTS.Text = "TS" + max;
                }
                maTS.Enabled = false;
            }
            reader.Close();

            btn_sua.Enabled = false;
            btn_luu.Enabled = true;

            tenTS.Text = "";
            sizeTS.Text = "Chọn size";
            tpTS.Text = "";
        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            string sql = "UPDATE TRASUA SET TenTS = N'" + tenTS.Text + "', Size = '" + sizeTS.Text + "', Topping = '" + tpTS.Text + "'  WHERE MaTS ='" + maTS.Text + "'";
            SqlCommand comd = new SqlCommand(sql, conn);
            ham.CapNhat(sql, conn);
            ham.HienThiDLDG(dataGVTS, "SELECT * FROM TRASUA", conn);
        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            string sql = "DELETE FROM TRASUA WHERE MaTS = '" + maTS.Text + "'";
            SqlCommand comd = new SqlCommand(sql, conn);
            ham.CapNhat(sql, conn);
            ham.HienThiDLDG(dataGVTS, "SELECT * FROM TRASUA", conn);
        }

        private void btn_luu_Click_1(object sender, EventArgs e)
        {
            string ma = maTS.Text;
            string ten = tenTS.Text;

            string sql = "INSERT INTO TRASUA(mats,tents,size,topping,hinhanh) VALUES ('" + ma + "', N'" + ten + "', '" + sizeTS.Text + "', N'" + tpTS.Text + "', '" + Path.GetFileName(link.Text) + "')";
            SqlCommand comd = new SqlCommand(sql, conn);
            comd.ExecuteNonQuery();
            ham.HienThiDLDG(dataGVTS, "SELECT * FROM TRASUA", conn);
        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
