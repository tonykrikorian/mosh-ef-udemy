using RelationshipDemo.Console.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationshipDemo.Console.EntityConfiguration
{
    public class VideoConfiguration : EntityTypeConfiguration<Video>
    {
        public VideoConfiguration()
        {
            HasRequired(x => x.Genre)
           .WithMany(x => x.Videos)
           .HasForeignKey(x => x.GenreID);

            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(255);

            Property(x => x.Classification)
                .IsRequired()
                .HasColumnType("tinyint");

            HasMany(x => x.Tags)
                .WithMany(x => x.Videos)
                .Map(x => {
                    x.ToTable("VideoTags");
                    x.MapLeftKey("VideoID");
                    x.MapRightKey("TagID");
                });
        }
    }
}
