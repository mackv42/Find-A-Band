using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.Models
{
    public class BandSongSamples
    {
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser User { get; set; }

        [Key]
        public int SongId { get; set; }

        public string FileName { get; set; }
        public string FingerPrint { get; set; }

        public int GenreId { get; set; }
    }
}
