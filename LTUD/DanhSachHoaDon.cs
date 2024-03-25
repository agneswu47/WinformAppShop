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
    public partial class DanhSachHoaDon : Form
    {
        SqlConnection conn = new SqlConnection();
        Ham ham = new Ham();

        public DanhSachHoaDon()
        {
            InitializeComponent();
        }

        private void DanhSachHoaDon_Load(object sender, EventArgs e)
        {
            ham.Ketnoi(conn);
            string sql = "SELECT HOADON.MaHD, HOADON.NgayLapHD, KHACHHANG.MaKH, KHACHHANG.HoTenKH, NHANVIEN.MaNV, NHANVIEN.HoTenNV, " +
                "TRASUA.TenTS, DOANVAT.TenDAV, CHITIETHOADON.SoLuong, CHITIETHOADON.DonGia, CHITIETHOADON.SoLuong*DonGia AS ThanhTien FROM HOADON " +
                "INNER JOIN KHACHHANG ON HOADON.ma_kh = KHACHHANG.MaKH " +
                "INNER JOIN NHANVIEN ON HOADON.ma_nv = NHANVIEN.MaNV " +
                "INNER JOIN CHITIETHOADON ON HOADON.MaHD = CHITIETHOADON.ma_hd " +
                "INNER JOIN TRASUA ON TRASUA.MaTS = CHITIETHOADON.ma_ts " +
                "INNER JOIN DOANVAT ON DOANVAT.MaDAV = CHITIETHOADON.ma_dav";
            ham.HienThiDLDG(dataGVDSHD, sql, conn);
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT HOADON.MaHD, HOADON.NgayLapHD, KHACHHANG.MaKH, KHACHHANG.HoTenKH, NHANVIEN.MaNV, NHANVIEN.HoTenNV, \r\n" +
                "TRASUA.TenTS, DOANVAT.TenDAV, CHITIETHOADON.SoLuong, CHITIETHOADON.DonGia, CHITIETHOADON.DonGia, CHITIETHOADON.SoLuong*DonGia AS ThanhTien FROM HOADON \r\n" +
                "INNER JOIN KHACHHANG ON HOADON.ma_kh = KHACHHANG.MaKH \r\n" +
                "INNER JOIN NHANVIEN ON HOADON.ma_nv = NHANVIEN.MaNV \r\n" +
                "INNER JOIN CHITIETHOADON ON HOADON.MaHD = CHITIETHOADON.ma_hd \r\n" +
                "INNER JOIN TRASUA ON TRASUA.MaTS = CHITIETHOADON.ma_ts \r\n" +
                "INNER JOIN DOANVAT ON DOANVAT.MaDAV = CHITIETHOADON.ma_dav WHERE HOADON.NgayLapHD BETWEEN '" + tungay.Value.ToString() + "' AND '" + denngay.Value.ToString() + "'";
            ham.HienThiDLDG(dataGVDSHD, sql, conn);
        }
    }
}
