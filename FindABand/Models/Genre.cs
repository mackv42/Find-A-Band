using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.Models
{
    public class Genre
    {
        public Genre() { }
        public Genre( string n )
        {
            Name = n;
        }
        [Key]
        public int GenreId { get; set; }
        public string Name { get; set; }
    }
}
