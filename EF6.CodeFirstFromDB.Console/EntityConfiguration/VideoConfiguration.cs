using EF6.CodeFirstFromDB.Console.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6.CodeFirstFromDB.Console.EntityConfiguration
{
    public class VideoConfiguration : EntityTypeConfiguration<Video>
    {
        public VideoConfiguration()
        {
            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
