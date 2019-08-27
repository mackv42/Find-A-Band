using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
// Accepted Invite makes bands and musicians can connect
namespace FindABand.Models
{
    public class AcceptedInvite
    {
        [Key]
        public int Id { get; set; }

        public int SenderId { get; set; }
        [NotMapped]
        public Band Sender { get; set; }
        public int RecipientId { get; set; }
        [NotMapped]
        public UserAccount Recipient { get; set; }
    }
}
