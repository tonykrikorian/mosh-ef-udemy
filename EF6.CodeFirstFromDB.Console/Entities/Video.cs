﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6.CodeFirstFromDB.Console.Entities
{
    public class Video
    {
     
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleasedDate { get; set; }
        public ICollection<Genre> Genres { get; set; }
        public int GenreID { get; set; }
        public Classification Classification { get; set; }

    }

    public enum Classification
    {
        Silver,
        Gold,
        Platimum
    }
}
