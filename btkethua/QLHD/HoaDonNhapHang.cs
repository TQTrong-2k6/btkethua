using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btkethua.QLHD
{
    public class HoaDonNhapHang: HoaDon
    {
        private string NhaCungCap;

        public HoaDonNhapHang() { }
        public HoaDonNhapHang(int SoHoaDon, DateTime NgayHoaDon, double SoTien, string NhaCungCap): base(SoHoaDon, NgayHoaDon, SoTien)
        {
            this.NhaCungCap = NhaCungCap;
        }
        public void inThongTinHoaDon()
        {
            base.inHoaDon();
            Console.WriteLine("Nha cung cap: " + NhaCungCap);
        }
    }
}
