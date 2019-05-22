using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationshipDemo.Console.Entities
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleasedDate { get; set; }

        public int GenreID { get; set; }
        public Genre Genre { get; set; }
        public Classification Classification { get; set; }
        public IList<Tag> Tags { get; set; }

    }

    public enum Classification:byte
    {
        Silver,
        Gold,
        Platinum
    } 
}
