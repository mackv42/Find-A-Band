using FindABand.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.ViewModels
{
    public class TakeBandRoadieTestViewModel
    {
        public TakeBandRoadieTestViewModel()
        {
            Questions = new List<BandRoadieTestQuestion>();
            Answers = new List<double>();
        }

        public List<BandRoadieTestQuestion> Questions { get; set; }
        public int BandId { get; set; }
        [BindProperty, Required]
        public List<double> Answers { get; set; }
    }
}
