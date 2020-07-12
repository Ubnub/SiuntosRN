using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiuntosRN
{
    public class Preke
    {
    public int ID { get; set; }
    
    public string Pavadinimas { get; set; }
    public int Kaina { get; set; }
    public int Likutis { get; set; }    
    public Preke(int id, int Price, string Name, int Amm)
    {
        ID = id;
        Kaina = Price;
        Pavadinimas = Name;     
        Likutis = Amm;        
    }
}
}
