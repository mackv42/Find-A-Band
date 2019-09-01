using FindABand.LocationUtils;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.Models
{
    public class UserAccount : IHasLocation
    {
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser User { get; set; }

        [Key]
        public int ProfileId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public List<TalentByInstrument> instrumentsPlayed { get; set; }
        [NotMapped]
        public List<Song> Songs { get; set; }
    }
}
