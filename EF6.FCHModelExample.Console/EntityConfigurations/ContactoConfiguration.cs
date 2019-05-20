using EF6.FCHModelExample.Console.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6.FCHModelExample.Console.EntityConfigurations
{
    public class ContactoConfiguration : EntityTypeConfiguration<Contacto>
    {
        public ContactoConfiguration()
        {

            ToTable("Contactos");


            Property(x => x.Name)
            .HasMaxLength(255)
            .IsRequired();


            Property(x => x.Cargo)
            .HasMaxLength(255)
            .IsRequired();
        }
    }
}
