using EF6.FCHModelExample.Console.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6.FCHModelExample.Console
{
    public class DataContext : DbContext
    {
        public DataContext():base("name=DefaultConnection")
        {

        }

        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<SolucionTecnologica> SolucionesTecnologicas { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<TipoEmpresa> TiposEmpresa { get; set; }
        public DbSet<EspecialidadesEmpresa> EspecialidadesEmpresas { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empresa>()
                .HasOptional(t => t.TipoEmpresa)
                .WithRequired(e => e.Empresa);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.EspecialidadesEmpresas)
                .WithMany(e => e.Empresas)
                .Map(x=> {
                    x.ToTable("EmpresasEspecialidades");
                    x.MapLeftKey("EmpresaID");
                    x.MapRightKey("EspecialidadID");

                });

            modelBuilder.Entity<Contacto>()
                .ToTable("Contactos");

            modelBuilder.Entity<Contacto>()
                .Property(x => x.Name)
                .HasMaxLength(255)
                .IsRequired();

            modelBuilder.Entity<Contacto>()
                .Property(x => x.Cargo)
                .HasMaxLength(255)
                .IsRequired();


            modelBuilder.Entity<SolucionTecnologica>()
                .ToTable("SolucionesTecnologicas");

            modelBuilder.Entity<TipoEmpresa>()
                .ToTable("TiposEmpresa");

            base.OnModelCreating(modelBuilder);
        }
    }
}
