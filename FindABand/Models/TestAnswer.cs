using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.Models
{
    public class TestAnswer
    {
        [Key]
        public int AnswerId { get; set; }
        public double Answer { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        [ForeignKey(nameof(TestQuestion))]
        public int QuestionId { get; set; }
        public RoadieTestQuestion TestQuestion { get; set; }

    }
}
