using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Doi
    {
        // Prototypes
        int maSoDoi;
        string donVi;
        VDV[] danhSachVDV = new VDV[4];
        public TimeSpan TGChayDoi = new TimeSpan(0,0,0);
        public int MaSoDoi { get => maSoDoi; set => maSoDoi = value; }
        public string DonVi { get => donVi; set => donVi = value; }
        internal VDV[] DanhSachVDV { get => danhSachVDV; set => danhSachVDV = value; }
        // Method
        public void NhapThongTinDoi()
        {
            // Nhap maSoDoi
            // Nhap donvi
        }
        public void NhapThongTinTVTrongDoi()
        {
           for(int i= 0; i < 4; i++)
            {

                danhSachVDV[i].NhapVDV();
            }
           foreach(VDV vdv in danhSachVDV)
            {
                TGChayDoi += vdv.TGChay;
            }
        }
        public void Xuat()
        {
            // Xuat TenDoi
            // Xuat DonVi
            foreach(VDV vDV in danhSachVDV)
            {
                vDV.XuatVDV();
            }
            // Tong TG chay cua doi la: 
        }
    }
}
