using EF6.FCHModelExample.Console.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6.FCHModelExample.Console.EntityConfigurations
{
    public class TipoEmpresaConfiguration: EntityTypeConfiguration<TipoEmpresa>
    {
        public TipoEmpresaConfiguration()
        {
           ToTable("TiposEmpresa");
        }
    }
}
