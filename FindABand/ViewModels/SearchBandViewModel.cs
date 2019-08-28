using FindABand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.ViewModels
{
    public class SearchBandViewModel
    {
        public SearchBandViewModel()
        {
            Bands = new List<Band>();
        }
        public List<Band> Bands { get; set; }
        public int SearchQuery { get; set; }
    }
}
