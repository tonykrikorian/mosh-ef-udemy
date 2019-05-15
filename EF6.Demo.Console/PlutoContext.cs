using EF6.Demo.Console.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6.Demo.Console
{
    class PlutoContext: DbContext
    {
        public PlutoContext():base("name=DefaultConnection")
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
