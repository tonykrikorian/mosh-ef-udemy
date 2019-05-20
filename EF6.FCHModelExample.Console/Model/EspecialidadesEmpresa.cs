using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6.FCHModelExample.Console.Model
{
    public class EspecialidadesEmpresa
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Empresa> Empresas { get; set; }
    }
}
