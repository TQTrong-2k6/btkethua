using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btkethua.QLHD
{
    public class HoaDonBanHang: HoaDon
    {
        protected string TenKhachHang;

        public HoaDonBanHang() { }
        public HoaDonBanHang(int SoHoaDon, DateTime NgayHoaDon, double SoTien, string TenKhachHang): base(SoHoaDon, NgayHoaDon, SoTien)
        {
            this.TenKhachHang = TenKhachHang;
        }
        public void InThongTinHoaDon()
        {
            base.inHoaDon();
            Console.WriteLine("Ten khach hang: " + TenKhachHang);
        }
    }
}
