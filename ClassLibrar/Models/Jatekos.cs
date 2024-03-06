using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrar.Models
{
    public class Jatekos
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Tipp> Tipp { get;  } = new List<Tipp>();

        public Jatekos() { }

        public Jatekos(string name)
        {
            Name = name;
        }
    }
}
