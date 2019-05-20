using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6.FCHModelExample.Console.Model
{
    public class SolucionTecnologica
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descripcion { get; set; }
        public Empresa Empresa { get; set; }
    }
}
