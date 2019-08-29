using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.Models
{
    public class BandMessage
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public int SenderId { get; set; }
        public int RecipientId { get; set; }
    }
}
