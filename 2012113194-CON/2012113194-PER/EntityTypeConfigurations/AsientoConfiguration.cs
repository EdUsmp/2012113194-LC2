using _2012113194_ENT;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012113194_PER.EntityTypeConfigurations
{
    public class AsientoConfiguration : EntityTypeConfiguration<Asiento>
    {
        //Asiento 1 - 1 Cinturon
        public AsientoConfiguration()
        {
            ToTable("Asiento");

            HasKey(a => a.AsientoId);

            Property(a => a.NumSerie).HasMaxLength(255);

            HasRequired(c => c.Cinturon)
                .WithRequiredPrincipal(a => a.Asiento);


            HasRequired(c => c.Carro)
               .WithMany(c => c.Asiento);


            //HasOptional(c => c.Cinturon)
               // .WithRequired(a => a.Asiento);

        }
    }
}
