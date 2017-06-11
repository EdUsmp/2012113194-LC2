using _2012113194_ENT;
using _2012113194_PER.EntityTypeConfigurations;
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
        public DbSet<Asiento> Asientos { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Cinturon> Cinturones { get; set; }
        public DbSet<Llanta> Llantas { get; set; }
        public DbSet<Parabrisas> Parabrisass { get; set; }
        public DbSet<Propietario> Propietarios { get; set; }
        public DbSet<Volante> Volantes { get; set; }

        public EnsambladoraDbContext()
            : base("EnsambladoraContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AsientoConfiguration());
            modelBuilder.Configurations.Add(new CarroConfiguration());
            modelBuilder.Configurations.Add(new CinturonConfiguration());
            modelBuilder.Configurations.Add(new LlantaConfiguration());
            modelBuilder.Configurations.Add(new ParabrisasConfiguration());
            modelBuilder.Configurations.Add(new PropietarioConfiguration());
            modelBuilder.Configurations.Add(new VolanteConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        //public System.Data.Entity.DbSet<_2012113194_ENT.Asiento> Asientoes { get; set; }

        //public System.Data.Entity.DbSet<_2012113194_ENT.Carro> Carroes { get; set; }

        //public System.Data.Entity.DbSet<_2012113194_ENT.Cinturon> Cinturons { get; set; }

        //public System.Data.Entity.DbSet<_2012113194_ENT.Parabrisas> Parabrisas { get; set; }
    }
}

