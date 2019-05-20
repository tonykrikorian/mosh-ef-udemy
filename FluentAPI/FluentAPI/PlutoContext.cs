using System.Data.Entity;

namespace DataAnnotations
{
    public class PlutoContext : DbContext
    {
        public PlutoContext()
            : base("name=PlutoContext")
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<Course>()
               .Property(c => c.Description)
               .IsRequired()
               .HasMaxLength(2000);

            modelBuilder.Entity<Course>()
                .HasRequired(a => a.Author)
                .WithMany(c => c.Courses)
                .HasForeignKey(a => a.AuthorId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tag>()
                .HasMany(c => c.Courses)
                .WithMany(t => t.Tags)
                .Map(t => t.ToTable("CourseTags"));

            modelBuilder.Entity<Course>()
                .HasRequired(x => x.Cover)
                .WithRequiredPrincipal(x => x.Course);


            base.OnModelCreating(modelBuilder);
        }
    }
}