using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.Models
{
    public class TalentByInstrument
    {
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public UserAccount User { get; set; }

        public int GenreId { get; set; }
    }
}
