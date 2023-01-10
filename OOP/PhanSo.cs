using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
 
    internal class PhanSo
    {
        private int tu;
        private int mau;

        public int Tu { get => tu; set => tu = value; }
        public int Mau { get => mau; set => mau = value; }

        public PhanSo()
        {

        }
        public PhanSo(int tu, int mau)
        {
            this.tu = tu;
            this.mau = mau;
        }
        public static void HelloWorld() // Hamf ngoaif khong can tao doi tuong Phan So
        {
            Console.Write("HelloWorld");
        }
        public  void Nhap() // 
        {

            Console.WriteLine("Nhap tu: ");
            tu=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau: ");
            mau = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine($"{tu} / {mau}");
        }
        public PhanSo Cong(PhanSo ps2)
        {
            PhanSo Tong = new PhanSo();
            Tong.tu = this.tu * ps2.Mau + this.mau * ps2.Tu;
            Tong.Mau = this.Mau * ps2.Mau;
            return Tong;
        }
        public static PhanSo operator+(PhanSo a, PhanSo b)
        {
            PhanSo Tong = new PhanSo();
            Tong.tu = a.tu * b.Mau + a.mau * b.Tu;
            Tong.Mau = a.Mau * b.Mau;
            return Tong;
        }
        public override string  ToString()
        {
            string kq = this.tu.ToString() + "/" + this.mau.ToString();
            return kq;
        }

    }
}
