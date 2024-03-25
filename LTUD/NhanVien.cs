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
using System.IO;
using System.Security.Policy;

namespace LTUD
{
    public partial class NhanVien : Form
    {
        SqlConnection conn = new SqlConnection();
        Ham ham = new Ham();
        string gtinh;

        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            ham.Ketnoi(conn);
            ham.HienThiDLDG(dataGVNV, "SELECT NHANVIEN.MaNV, NHANVIEN.HoTenNV, NHANVIEN.GioiTinh, NHANVIEN.NgaySinh, NHANVIEN.SDT, USERS.Password\r\n" +
                         "FROM NHANVIEN INNER JOIN USERS ON NHANVIEN.MaNV = USERS.MaNV" , conn);
        }

        private void dataGVNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gtinh == "Nữ")
            {
                nu.Checked = true;
            }
            else
            {
                nam.Checked = true;
            }

            maNV.Text = dataGVNV.Rows[e.RowIndex].Cells[0].Value.ToString();
            htenNV.Text = dataGVNV.Rows[e.RowIndex].Cells[1].Value.ToString();
            nsNV.Text = dataGVNV.Rows[e.RowIndex].Cells[3].Value.ToString();
            sdtNV.Text = dataGVNV.Rows[e.RowIndex].Cells[4].Value.ToString();
            passdn.Text = dataGVNV.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            string malonnhat = "SELECT MAX(SUBSTRING(MaNV, 3, 2)) FROM NHANVIEN";
            SqlCommand comd = new SqlCommand(malonnhat, conn);
            SqlDataReader reader = comd.ExecuteReader();

            if (reader.Read())
            {
                int max = Convert.ToInt32(reader.GetValue(0).ToString()) + 1;
                if (max < 10)
                {
                    maNV.Text = "NV0" + max;
                }
                else
                {
                    maNV.Text = "NV" + max;
                }

                maNV.Enabled = false;
            }

            reader.Close();
            btn_sua.Enabled = false;
            btn_luu.Enabled = true;

            htenNV.Text = "";
            sdtNV.Text = "";
        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            string sql = "UPDATE NHANVIEN SET HoTenNV = N'" + htenNV.Text + "', SDT = '" + sdtNV.Text + "' WHERE MaNV ='" + maNV.Text + "'";
            SqlCommand comd = new SqlCommand(sql, conn);
            ham.CapNhat(sql, conn);
            ham.HienThiDLDG(dataGVNV, "SELECT NHANVIEN.MaNV, NHANVIEN.HoTenNV, NHANVIEN.GioiTinh, NHANVIEN.NgaySinh, NHANVIEN.SDT, USERS.Password\r\n" +
                         "FROM NHANVIEN INNER JOIN USERS ON NHANVIEN.MaNV = USERS.MaNV", conn);
        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            string sql_del_pass = "DELETE FROM USERS WHERE MaNV = '" + maNV.Text + "'";
            SqlCommand comd_del_pass = new SqlCommand(sql_del_pass, conn);
            ham.CapNhat(sql_del_pass, conn);

            string sql = "DELETE FROM NHANVIEN WHERE MaNV =  '" + maNV.Text + "'";
            SqlCommand comd = new SqlCommand(sql, conn);
            ham.CapNhat(sql, conn);

            ham.HienThiDLDG(dataGVNV, "SELECT NHANVIEN.MaNV, NHANVIEN.HoTenNV, NHANVIEN.GioiTinh, NHANVIEN.NgaySinh, NHANVIEN.SDT, USERS.Password\r\n" +
                         "FROM NHANVIEN INNER JOIN USERS ON NHANVIEN.MaNV = USERS.MaNV", conn);
        }

        private void btn_luu_Click_1(object sender, EventArgs e)
        {
            if (nu.Checked == true)
            {
                gtinh = nu.Text;
            }
            else
            {
                gtinh = nam.Text;
            };

            string ma = maNV.Text;
            string hoten = htenNV.Text;
            string ns = nsNV.Value.ToString();
            string sdt = sdtNV.Text;

            string sql = "INSERT INTO NHANVIEN(manv,hotennv,gioitinh,ngaysinh,sdt) VALUES ('" + ma + "', N'" + hoten + "', N'" + gtinh + "', '" + ns + "', '" + sdt + "')";
            SqlCommand comd = new SqlCommand(sql, conn);
            ham.CapNhat(sql, conn);

            string sql_dn = "INSERT INTO Users(manv,password) VALUES ('" + maNV.Text + "', '" + passdn.Text + "')";
            SqlCommand comd_dn = new SqlCommand(sql_dn, conn);
            ham.CapNhat(sql_dn, conn);
            ham.HienThiDLDG(dataGVNV, "SELECT NHANVIEN.MaNV, NHANVIEN.HoTenNV, NHANVIEN.GioiTinh, NHANVIEN.NgaySinh, NHANVIEN.SDT, USERS.Password\r\n" +
                         "FROM NHANVIEN INNER JOIN USERS ON NHANVIEN.MaNV = USERS.MaNV", conn);
        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
