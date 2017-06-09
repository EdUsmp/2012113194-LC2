using _2012113194_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012113194_PER.EntityTypeConfigurations
{
    public class CinturonConfiguration : EntityTypeConfiguration<Cinturon>
    {
        public CinturonConfiguration()
        {
            ToTable("Cinturon");

            HasKey(c => c.CinturonId);

            Property(c => c.CinturonId);
            Property(a => a.NumSerie).HasMaxLength(255);
            //Property(a => a.Metraje).HasMaxLength();

        }
    }
}
