using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6.FCHModelExample.Console.Model
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Rut { get; set; }
        public string Name { get; set; }
        public ICollection<SolucionTecnologica> SolucionesTecnologicas { get; set; }
        public ICollection<Contacto> Contactos { get; set; }
        public TipoEmpresa TipoEmpresa { get; set; }
        public ICollection<EspecialidadesEmpresa> EspecialidadesEmpresas { get; set; }
    }
}
