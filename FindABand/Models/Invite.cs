﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.Models
{
    public class Invite
    {
        //band that sent invite
        public int SenderId { get; set; }
        [NotMapped]
        public Band Sender { get; set; }
        
        //Musician that recieved invite

        public int RecipientId { get; set; }
        [NotMapped]
        public UserAccount Recipient { get; set; }

        public string Message { get; set; }

        [Key]
        public int Id { get; set; }


    }
}
