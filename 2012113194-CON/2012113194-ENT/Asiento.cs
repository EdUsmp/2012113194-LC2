﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012113194_ENT
{
    class Asiento
    {
        public string NumSerie { get; set; }

        public Carro Carro { get; set;}
        public List<Cinturon> Cinturones { get; set; }

        public Asiento()
        {
            Cinturones = new List<Cinturon>();
        }
    }
}
