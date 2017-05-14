using _2012113194_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012113194_PER
{
    public class EnsambladoraDbContext : DbContext
    {
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Automovil> Automovil { get; set; }
        public DbSet<Ensambladora> Ensambladora { get; set; }
        public DbSet <Parabrisas> Parabrisas { get; set; }
    }
}
