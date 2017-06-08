﻿using _2012113194_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012113194_PER.EntityTypeConfigurations
{
    public class BusConfiguration : EntityTypeConfiguration<Bus>
    {
        public BusConfiguration()
        {
            ToTable("Bus");

            HasKey(b => b.BusId);

            Property(b => b.BusId);

        }
    }
}
