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
        public int? Id { get; set; }

        public int? UserSenderId { get; set; }
        [NotMapped]
        public UserAccount UserSender { get; set; }
        public int? BandSenderId { get; set; }
        [NotMapped]
        public Band BandSender { get; set; }

        public int? UserRecipientId { get; set; }
        [NotMapped]
        public UserAccount Recipient { get; set; }

        public int? BandRecipientId { get; set; }
        [NotMapped]
        public Band BandRecipient { get; set; }
    }
}
