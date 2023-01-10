using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class VDV
    {
        int maSo;
        string hoTen;
        int tuoi;
        int maSoDoi;
        public TimeSpan TGChay;

        public int MaSo { get => maSo; set => maSo = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }

        public void NhapVDV()
        {
            int gio, phut, giay;
            // Nhap MaSO
            Console.WriteLine("Nhap ...");
            // Nhap HoTen
            // Nhap Tuoi
            // Nhap gio chay
            // Nhap phut chay
            // Nhap gio giay chay
            TGChay = new TimeSpan(gio, phut, giay);
        }
        public void XuatVDV()
        {

        }
        public override string ToString()
        {
            return 
        }

    }
}
