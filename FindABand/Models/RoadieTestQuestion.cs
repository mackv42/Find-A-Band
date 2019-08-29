using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.Models
{
    public class RoadieTestQuestion
    {
        [Key]
        public int QuestionId { get; set; }
        public string Question { get; set; }
    }
}
