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
    public class CarroConfiguration : EntityTypeConfiguration<Carro>
    {
        //Carro 1- M Asiento
        //Carro 1- M Llanta
        //Carri M- 1 Ensambladora
        public CarroConfiguration()
        {
            ToTable("Carro");

            HasKey(c => c.CarroId);

            Property(c => c.CarroId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(c => c.Ensambladora)
                .WithMany(c => c.Carros);





        }
    }
}
