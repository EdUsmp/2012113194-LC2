using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012113194_ENT
{
    public class Asiento
    {
        public int AsientoId { get; set; }
        public Cinturon Cinturon { get; set; }
        public string NumSerie { get; set; }
        public Asiento()
        {
            Cinturon = new Cinturon();
        }
    }
}
