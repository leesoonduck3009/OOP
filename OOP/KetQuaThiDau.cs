using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class KetQuaThiDau
    {
        private List<VDV> danhSachVDVNhanhNhat = new List<VDV>();
        private List<Doi> danhSachDoi = new List<Doi>();

        public List<VDV> DanhSachVDVNhanhNhat { get => danhSachVDVNhanhNhat; set => danhSachVDVNhanhNhat = value; }
        public List<Doi> DanhSachDoi { get => danhSachDoi; set => danhSachDoi = value; }

        public KetQuaThiDau()
        {

        }
        public KetQuaThiDau( List<Doi> DSDoi)
        {

        }
        public void Xuat()
        {

        }
    }
}
