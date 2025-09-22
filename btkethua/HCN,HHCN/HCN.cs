using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btkethua.HCN_HHCN
{
    public class HCN
    {
        protected double a, b; // a chieu dai, b chieu rong
        public HCN() 
        {
        }
        public HCN(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public void nhap()
        {
            Console.Write("Nhap chieu dai: "); a = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: "); b = double.Parse(Console.ReadLine());
        }
        public void hienthi()
        {
            Console.WriteLine("Chieu dai HCN la: " + a);
            Console.WriteLine("Chieu rong HCN la: " + b);
            Console.WriteLine("Dien tich HCN la: " + tinhDT());
        }
        public double tinhDT()
        {
            return a * b;
        }
    }
}
