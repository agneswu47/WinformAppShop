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
    public partial class HoaDon : Form
    {
        public string auto_link = AppDomain.CurrentDomain.BaseDirectory + "\\Fold_Hinh\\";

        SqlConnection conn = new SqlConnection();
        Ham ham = new Ham();

        public HoaDon(String usersd)
        {
            InitializeComponent();
            maNV.Text = usersd;
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {
            ham.Ketnoi(conn);
            string sql = "SELECT HOADON.MaHD, HOADON.NgayLapHD, KHACHHANG.MaKH, KHACHHANG.HoTenKH, KHACHHANG.DiaChi, KHACHHANG.SDT, NHANVIEN.MaNV, NHANVIEN.HoTenNV, \r\n" +
                         "TRASUA.TenTS, DOANVAT.TenDAV, CHITIETHOADON.SoLuong, CHITIETHOADON.DonGia, CHITIETHOADON.SoLuong*DonGia AS ThanhTien\r\n" +
                         "FROM (((HOADON INNER JOIN KHACHHANG ON HOADON.ma_kh = KHACHHANG.MaKH)\r\n" +
                         "INNER JOIN NHANVIEN ON HOADON.ma_nv = NHANVIEN.MaNV) \r\n" +
                         "INNER JOIN CHITIETHOADON ON HOADON.MaHD = CHITIETHOADON.ma_hd)\r\n" +
                         "INNER JOIN TRASUA ON TRASUA.MaTS = CHITIETHOADON.ma_ts \r\n" +
                         "INNER JOIN DOANVAT ON DOANVAT.MaDAV = CHITIETHOADON.ma_dav";
            ham.HienThiDLDG(dataGVHD, sql, conn);
            ham.LoadComb(tenTS, "SELECT MaTS, TenTS FROM TRASUA", conn, "TenTS", "MaTS");
            ham.LoadComb(tenDAV, "SELECT MaDAV, TenDAV FROM DOANVAT", conn, "TenDAV", "MaDAV");
        }

        private void dataGVHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_them.Enabled = false;
            btn_luu.Enabled = false;

            maHD.Text = dataGVHD.Rows[e.RowIndex].Cells[0].Value.ToString();
            ngaylap.Text = dataGVHD.Rows[e.RowIndex].Cells[1].Value.ToString();
            maKH.Text = dataGVHD.Rows[e.RowIndex].Cells[2].Value.ToString();
            hotenKH.Text = dataGVHD.Rows[e.RowIndex].Cells[3].Value.ToString();
            diachiKH.Text = dataGVHD.Rows[e.RowIndex].Cells[4].Value.ToString();
            sdtKH.Text = dataGVHD.Rows[e.RowIndex].Cells[5].Value.ToString();
            maNV.Text = dataGVHD.Rows[e.RowIndex].Cells[6].Value.ToString();
            hotenNV.Text = dataGVHD.Rows[e.RowIndex].Cells[7].Value.ToString();
            tenTS.Text = dataGVHD.Rows[e.RowIndex].Cells[8].Value.ToString();
            tenDAV.Text = dataGVHD.Rows[e.RowIndex].Cells[9].Value.ToString();
            soluong.Text = dataGVHD.Rows[e.RowIndex].Cells[10].Value.ToString();
            dongia.Text = dataGVHD.Rows[e.RowIndex].Cells[11].Value.ToString();
            
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            string malonnhat = "SELECT MAX(SUBSTRING(MaHD, 3, 2)) FROM HOADON";
            SqlCommand comd = new SqlCommand(malonnhat, conn);
            SqlDataReader reader = comd.ExecuteReader();

            if (reader.Read())
            {
                int max = Convert.ToInt32(reader.GetValue(0).ToString()) + 1;
                if (max < 10)
                {
                    maHD.Text = "HD0" + max;
                }
                else
                {
                    maHD.Text = "HD" + max;
                }
                maHD.Enabled = false;
            }
            reader.Close();

            btn_sua.Enabled = false;
            btn_luu.Enabled = true;

            tenTS.Text = "Chọn trà sữa";
            tenDAV.Text = "Chọn đồ ăn vặt";
            soluong.Text = "";
            dongia.Text = "";
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql_cthd = "DELETE FROM CHITIETHOADON WHERE ma_hd = '" + maHD.Text + "'";
            SqlCommand comd_cthd = new SqlCommand(sql_cthd, conn);
            ham.CapNhat(sql_cthd, conn);

            string sql_hd = "DELETE FROM HOADON WHERE MaHD = '" + maHD.Text + "'";
            SqlCommand comd_hd = new SqlCommand(sql_hd, conn);
            ham.CapNhat(sql_hd, conn);

            string sql_kh = "DELETE FROM KHACHHANG WHERE MaKH = '" + maKH.Text + "'";
            SqlCommand comd_kh = new SqlCommand(sql_kh, conn);
            ham.CapNhat(sql_kh, conn);

            string sql = "SELECT HOADON.MaHD, HOADON.NgayLapHD, KHACHHANG.MaKH, KHACHHANG.HoTenKH, KHACHHANG.DiaChi, KHACHHANG.SDT, NHANVIEN.MaNV, NHANVIEN.HoTenNV, \r\n" +
                         "TRASUA.TenTS, DOANVAT.TenDAV, CHITIETHOADON.SoLuong, CHITIETHOADON.DonGia, CHITIETHOADON.SoLuong*DonGia AS ThanhTien\r\n" +
                         "FROM (((HOADON INNER JOIN KHACHHANG ON HOADON.ma_kh = KHACHHANG.MaKH)\r\n" +
                         "INNER JOIN NHANVIEN ON HOADON.ma_nv = NHANVIEN.MaNV) \r\n" +
                         "INNER JOIN CHITIETHOADON ON HOADON.MaHD = CHITIETHOADON.ma_hd)\r\n" +
                         "INNER JOIN TRASUA ON TRASUA.MaTS = CHITIETHOADON.ma_ts \r\n" +
                         "INNER JOIN DOANVAT ON DOANVAT.MaDAV = CHITIETHOADON.ma_dav";
            ham.HienThiDLDG(dataGVHD, sql, conn);
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            string ma = maHD.Text;
            string nlhd = ngaylap.Value.ToString();
            string makh = maKH.Text;
            string htkh = hotenKH.Text;
            string dckh = diachiKH.Text;
            string sdtkh = sdtKH.Text;
            string manv = maNV.Text;
            // htnv = hotenNV.Text;
            string sl = soluong.Text;
            string dg = dongia.Text;

            string sql_kh = "INSERT INTO KHACHHANG(makh,hotenkh,diachi,sdt) VALUES ('" + makh + "', '" + htkh + "', '" + dckh + "', '" + sdtkh + "')";
            SqlCommand comd_kh = new SqlCommand(sql_kh, conn);
            ham.CapNhat(sql_kh, conn);
            string sql_hd = "INSERT INTO HOADON(mahd,ngaylaphd,ma_kh,ma_nv) VALUES ('" + ma + "', '" + nlhd + "', '" + makh + "', '" + manv + "')";
            SqlCommand comd_hd = new SqlCommand(sql_hd, conn);
            ham.CapNhat(sql_hd, conn);
            string sql_cthd = "INSERT INTO CHITIETHOADON(soluong,dongia,ma_ts,ma_dav,ma_hd) VALUES ('" + sl + "', '" + dg + "', '" + tenTS.SelectedValue.ToString() + "', '" + tenDAV.SelectedValue.ToString() + "','" + ma + "')";
            SqlCommand comd_cthd = new SqlCommand(sql_cthd, conn);
            ham.CapNhat(sql_cthd, conn);

            string sql = "SELECT HOADON.MaHD, HOADON.NgayLapHD, KHACHHANG.MaKH, KHACHHANG.HoTenKH, KHACHHANG.DiaChi, KHACHHANG.SDT, NHANVIEN.MaNV, NHANVIEN.HoTenNV, \r\n" +
                         "TRASUA.TenTS, DOANVAT.TenDAV, CHITIETHOADON.SoLuong, CHITIETHOADON.DonGia, CHITIETHOADON.SoLuong*DonGia AS ThanhTien\r\n" +
                         "FROM (((HOADON INNER JOIN KHACHHANG ON HOADON.ma_kh = KHACHHANG.MaKH)\r\n" +
                         "INNER JOIN NHANVIEN ON HOADON.ma_nv = NHANVIEN.MaNV) \r\n" +
                         "INNER JOIN CHITIETHOADON ON HOADON.MaHD = CHITIETHOADON.ma_hd)\r\n" +
                         "INNER JOIN TRASUA ON TRASUA.MaTS = CHITIETHOADON.ma_ts \r\n" +
                         "INNER JOIN DOANVAT ON DOANVAT.MaDAV = CHITIETHOADON.ma_dav";

            ham.HienThiDLDG(dataGVHD, sql, conn);
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql_sua = "UPDATE CHITIETHOADON SET SoLuong = '" + soluong.Text + "', DonGia = '" + dongia.Text + "' WHERE ma_hd = '" + maHD.Text + "'";
            SqlCommand comd = new SqlCommand(sql_sua, conn);
            ham.CapNhat(sql_sua, conn);

            string sql_kh = "UPDATE KHACHHANG SET HoTenKH = '" + hotenKH.Text + "', DiaChi = '" + diachiKH + "', SDT = '" + sdtKH + "'";
            SqlCommand comd_kh = new SqlCommand(sql_kh, conn);
            ham.CapNhat(sql_kh, conn);

            string sql = "SELECT HOADON.MaHD, HOADON.NgayLapHD, KHACHHANG.MaKH, KHACHHANG.HoTenKH, KHACHHANG.DiaChi, KHACHHANG.SDT, NHANVIEN.MaNV, NHANVIEN.HoTenNV, \r\n" +
                         "TRASUA.TenTS, DOANVAT.TenDAV, CHITIETHOADON.SoLuong, CHITIETHOADON.DonGia, CHITIETHOADON.SoLuong*DonGia AS ThanhTien\r\n" +
                         "FROM (((HOADON INNER JOIN KHACHHANG ON HOADON.ma_kh = KHACHHANG.MaKH)\r\n" +
                         "INNER JOIN NHANVIEN ON HOADON.ma_nv = NHANVIEN.MaNV) \r\n" +
                         "INNER JOIN CHITIETHOADON ON HOADON.MaHD = CHITIETHOADON.ma_hd)\r\n" +
                         "INNER JOIN TRASUA ON TRASUA.MaTS = CHITIETHOADON.ma_ts \r\n" +
                         "INNER JOIN DOANVAT ON DOANVAT.MaDAV = CHITIETHOADON.ma_dav";
            ham.HienThiDLDG(dataGVHD, sql, conn);
        }
        private void btn_themmathang_Click(object sender, EventArgs e)
        {
            thongtinKH.Enabled = false;
            thongtinHD.Enabled = false;
            thongtinNV.Enabled = false;

            string sql_cthd = "INSERT INTO CHITIETHOADON(soluong,dongia,ma_ts,ma_dav,ma_hd) VALUES ('" + soluong.Text + "', '" + dongia.Text + "', '" + tenTS.SelectedValue.ToString() + "', '" + tenDAV.SelectedValue.ToString() + "','" + maHD.Text + "')";
            SqlCommand comd_cthd = new SqlCommand(sql_cthd, conn);
            ham.CapNhat(sql_cthd, conn);

            string sql = "SELECT HOADON.MaHD, HOADON.NgayLapHD, KHACHHANG.MaKH, KHACHHANG.HoTenKH, KHACHHANG.DiaChi, KHACHHANG.SDT, NHANVIEN.MaNV, NHANVIEN.HoTenNV, \r\n" +
                         "TRASUA.TenTS, DOANVAT.TenDAV, CHITIETHOADON.SoLuong, CHITIETHOADON.DonGia, CHITIETHOADON.SoLuong*DonGia AS ThanhTien\r\n" +
                         "FROM (((HOADON INNER JOIN KHACHHANG ON HOADON.ma_kh = KHACHHANG.MaKH)\r\n" +
                         "INNER JOIN NHANVIEN ON HOADON.ma_nv = NHANVIEN.MaNV) \r\n" +
                         "INNER JOIN CHITIETHOADON ON HOADON.MaHD = CHITIETHOADON.ma_hd)\r\n" +
                         "INNER JOIN TRASUA ON TRASUA.MaTS = CHITIETHOADON.ma_ts \r\n" +
                         "INNER JOIN DOANVAT ON DOANVAT.MaDAV = CHITIETHOADON.ma_dav";
            ham.HienThiDLDG(dataGVHD, sql, conn);
        }
        private void btn_xuat_Click(object sender, EventArgs e)
        {
            DanhSachHoaDon dshd = new DanhSachHoaDon();
            dshd.Show();
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
