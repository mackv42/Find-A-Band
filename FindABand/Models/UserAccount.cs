﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.Models
{
    public class UserAccount
    {
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser User { get; set; }

        [Key]
        public int ProfileId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual List<TalentByInstrument> InstrumentsPlayed { get; set; }
        public virtual List<TalentByGenre> GenresPlayed { get; set; }
    }
}
