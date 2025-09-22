using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btkethua.HCN_HHCN
{
    public class HHCN: HCN
    {
        private double h; // h: chieu cao
        public HHCN(): base(){}
        public HHCN(double a, double b, double h) : base(a, b)
        {
            this.h = h;
        }
        public void nhap()
        {
            base.nhap();
            Console.Write("Nhap chieu cao: "); h = double.Parse(Console.ReadLine());
        }
        public void hienthi()
        {
            base.hienthi();
            Console.WriteLine("Chieu dai: " + h);
            Console.WriteLine("The tich HHHN la: " + tinhTheTich());
        }
        public double tinhTheTich()
        {
            return h * tinhDT();
        }
    }
}
