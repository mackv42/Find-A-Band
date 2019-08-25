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
        [Key]
        public int SongSampleId { get; set; }

        [ForeignKey(nameof(_Band))]
        public string UserId { get; set; }
        public Band _Band { get; set; }
    }
}
