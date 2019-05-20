using EF6.FCHModelExample.Console.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6.FCHModelExample.Console.EntityConfigurations
{
    class SolucionTecnologicaConfiguration : EntityTypeConfiguration<SolucionTecnologica>
    {
        public SolucionTecnologicaConfiguration()
        {

              ToTable("SolucionesTecnologicas");
        }
    }
}
