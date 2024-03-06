using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrar.Models
{
    public class Tipp
    {
        public int Id { get; set; }
        public int JatekosId { get; set; }
        public int  Sz1 { get; set; }
        public int Sz2 { get; set;} 
        public int Sz3 { get; set;}
        public int Sz4 { get; set;}
        public int Sz5 { get; set;}

        public Tipp()
        {
        } 
        
        public Tipp(string sor)
        {
            string[] adatok = sor.Split(";");
            this.JatekosId = Convert.ToInt32(adatok[0]);
            this.Sz1 = Convert.ToInt32(adatok[1]);
            this.Sz2 = Convert.ToInt32(adatok[2]);
            this.Sz3 = Convert.ToInt32(adatok[3]);
            this.Sz4 = Convert.ToInt32(adatok[4]);
            this.Sz5 = Convert.ToInt32(adatok[5]);

        }


    }
}
