using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.Models
{
    public class RoadieTestQuestion
    {
        public RoadieTestQuestion(string question)
        {
            Question = question;
        }

        [Key]
        public int QuestionId { get; set; }
        public string Question { get; set; }
    }
}
