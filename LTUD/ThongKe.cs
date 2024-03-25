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
    public partial class ThongKe : Form
    {
        SqlConnection conn = new SqlConnection();
        Ham ham = new Ham();

        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            ham.Ketnoi(conn);
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT HOADON.MaHD, HOADON.NgayLapHD, KHACHHANG.MaKH, KHACHHANG.HoTenKH, NHANVIEN.MaNV, NHANVIEN.HoTenNV, \r\n" +
                "TRASUA.TenTS, DOANVAT.TenDAV, CHITIETHOADON.SoLuong, CHITIETHOADON.DonGia, CHITIETHOADON.DonGia, CHITIETHOADON.SoLuong*DonGia AS ThanhTien FROM HOADON \r\n" +
                "INNER JOIN KHACHHANG ON HOADON.ma_kh = KHACHHANG.MaKH \r\n" +
                "INNER JOIN NHANVIEN ON HOADON.ma_nv = NHANVIEN.MaNV \r\n" +
                "INNER JOIN CHITIETHOADON ON HOADON.MaHD = CHITIETHOADON.ma_hd \r\n" +
                "INNER JOIN TRASUA ON TRASUA.MaTS = CHITIETHOADON.ma_ts \r\n" +
                "INNER JOIN DOANVAT ON DOANVAT.MaDAV = CHITIETHOADON.ma_dav WHERE HOADON.NgayLapHD BETWEEN '" + tungay.Value.ToString() + "' AND '" + denngay.Value.ToString() + "'";

            string tt = "SELECT SUM(SoLuong*DonGia)\r\n" +
                        "FROM CHITIETHOADON\r\n" +
                        "INNER JOIN HOADON ON HOADON.MaHD = CHITIETHOADON.ma_hd\r\n" +
                        "WHERE HOADON.NgayLapHD BETWEEN '" + tungay.Value.ToString() + "' AND '" + denngay.Value.ToString() + "'";
            SqlCommand comd = new SqlCommand(tt, conn);
            SqlDataReader reader = comd.ExecuteReader();

            if (reader.Read())
            {
                int money = Convert.ToInt32(reader.GetValue(0).ToString());
                tongtien.Text = money.ToString();
            }
            reader.Close();
            ham.HienThiDLDG(dataGVTK, sql, conn);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
