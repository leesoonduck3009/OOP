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
            List<Doi> DSdoi = new List<Doi>();
            for(int i=0;i<8;i++)
            {
                // Doi thu i+1
                Doi doi1 = new Doi();
                doi1.NhapThongTinDoi();
                doi1.NhapThongTinTVTrongDoi();
                DSdoi.Add(doi1);
            }
            KetQuaThiDau ketQuaThiDau = new KetQuaThiDau(DSdoi);
            ketQuaThiDau.Xuat();
        }
    }
}
