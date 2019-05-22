﻿using RelationshipDemo.Console.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationshipDemo.Console.EntityConfiguration
{
    public class GenreConfiguration: EntityTypeConfiguration<Genre>
    {
        public GenreConfiguration()
        {
            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
