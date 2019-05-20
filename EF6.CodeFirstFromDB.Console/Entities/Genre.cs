using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6.CodeFirstFromDB.Console.Entities
{
    public class Genre
    {
        [ForeignKey("Video")]
        public int Id { get; set; }
        public string Name { get; set; }
        public Video Video { get; set; }

    }
}
