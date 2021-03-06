﻿using _2012113194_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012113194_PER.EntityTypeConfigurations
{
    public class LlantaConfiguration : EntityTypeConfiguration<Llanta>
    {
        public LlantaConfiguration()
        {
            ToTable("Llanta");

            HasKey(l => l.LlantaId);

            Property(l => l.LlantaId);

            HasRequired(c => c.Carro)
               .WithMany(c => c.Llantas);

        }
    }
}
