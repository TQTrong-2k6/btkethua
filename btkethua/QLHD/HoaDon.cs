using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btkethua.QLHD
{
    public class HoaDon
    {
        protected int SoHoaDon;
        protected DateTime NgayHoaDon;
        protected double SoTien;

        public HoaDon() { }
        public HoaDon(int SoHoaDon, DateTime NgayHoaDon, double SoTien)
        {
            this.SoHoaDon = SoHoaDon;
            this.NgayHoaDon = NgayHoaDon;
            this.SoTien = SoTien;
        }
        public void inHoaDon()
        {
            Console.WriteLine("So hoa don: " + SoHoaDon);
            Console.WriteLine("Ngay hoa don: "+ NgayHoaDon);
            Console.WriteLine("So tien: "+  SoTien);
        }
    }
}
