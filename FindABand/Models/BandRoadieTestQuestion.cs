using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.Models
{
    public class BandRoadieTestQuestion
    {
        [Key]
        public int Id { get; set; }
        public string Question { get; set; }
        public double Weight { get; set; }
        public int BandId { get; set; }
    }
}
