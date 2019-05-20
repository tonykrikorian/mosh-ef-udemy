using DataAnnotations;
using EF6.FCHModelExample.Console.Model;
using System.Data.Entity.ModelConfiguration;

namespace EF6.FCHModelExample.Console.EntityConfigurations
{
    public class EmpresaConfiguration : EntityTypeConfiguration<Empresa>
    {
        public EmpresaConfiguration()
        {
               HasOptional(t => t.TipoEmpresa)
              .WithRequired(e => e.Empresa);


             HasMany(e => e.EspecialidadesEmpresas)
            .WithMany(e => e.Empresas)
            .Map(x =>
            {
                x.ToTable("EmpresasEspecialidades");
                x.MapLeftKey("EmpresaID");
                x.MapRightKey("EspecialidadID");

            });
        }
    }
}
