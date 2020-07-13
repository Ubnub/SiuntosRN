using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiuntosRN
{
    public class Siunta
    {

        List<Preke> SiuntosKrepselis = new List<Preke>();
        public int Dydis { get; set; }
        public int Kaina { get; set; }
        
        public Siunta(List<Preke> Krepeslis)
        {
            SiuntosKrepselis = Krepeslis;
        }

        public void SkaiciuotiDydi()
        {
            int a = 0;
            foreach (var item in SiuntosKrepselis)
            {
                a += item.Likutis;
            }
            if (a <= 5)
            {
                Dydis = 1;
            }
            else if (a >5 && a <=15)
            {
                Dydis = 2;
            }
            else if(a>15)
            {
                Dydis = 3;
            }            
        }
        public void SkaiciuotiKaina()
        {
            int b = 0;
            foreach (var item in SiuntosKrepselis)
            {
                b += item.Kaina;
            }
            Kaina = b + Dydis;
        }
    }
}
