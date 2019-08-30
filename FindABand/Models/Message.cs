using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public string SenderId { get; set; }
        public int? SenderBandId { get; set; }
        public string RecipientId { get; set; }
        public int? RecipientBandId { get; set; }
    }
}
