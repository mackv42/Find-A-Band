using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.Models
{
    public class TalentByGenre
    {
        [Key]
        public int TalentKey { get; set; }
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public UserAccount User { get; set; }
        public int GenreId { get; set; }
    }
}
