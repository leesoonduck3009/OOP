using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhanSo phanSo = new PhanSo();
            phanSo.Nhap();
            phanSo.Xuat();
            PhanSo phanSo2 = new PhanSo(3,4);
            PhanSo Tong = new PhanSo();
            Tong = phanSo + phanSo2;
            Tong.Xuat();
            Console.WriteLine(Tong.ToString());
            ConVat conVat = new ConCho();
            Console.ReadKey();


        }
    }
}
