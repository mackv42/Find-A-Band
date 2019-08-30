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
    public class Band : IHasLocation
    {
        [Key]
        public int BandId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public int GenreId { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        [NotMapped]
        public string GenreName { get; set; }
        [NotMapped]
        public List<BandSongSample> Songs { get; set; }
    }
}
