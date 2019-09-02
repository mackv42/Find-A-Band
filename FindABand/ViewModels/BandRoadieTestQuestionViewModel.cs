using FindABand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.ViewModels
{
    public class BandRoadieTestQuestionViewModel
    {
        public BandRoadieTestQuestionViewModel()
        {

        }

        public List<BandRoadieTestQuestion> TestQuestions { get; set; }
        public BandRoadieTestQuestion NewQuestion { get; set; }
    }
}
