using EF6.FCHModelExample.Console.EntityConfigurations;
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
            modelBuilder.Configurations.Add(new EmpresaConfiguration());
            modelBuilder.Configurations.Add(new ContactoConfiguration());
            modelBuilder.Configurations.Add(new SolucionTecnologicaConfiguration());
            modelBuilder.Configurations.Add(new TipoEmpresaConfiguration());
        }
    }
}
