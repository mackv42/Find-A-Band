using FindABand.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.ViewModels
{
    public class TakeTestViewModel
    {
        public TakeTestViewModel()
        {
            Questions = new List<RoadieTestQuestion>();
            Answers = new List<double>();
        }
        
        public List<RoadieTestQuestion> Questions { get; set; }

        [BindProperty, Required]
        public List<double> Answers { get; set; }
    }
}