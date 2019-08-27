using FindABand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.ViewModels
{
    public class InstrumentViewModel
    {
        public InstrumentViewModel()
        {
            PlayedInstruments = new List<Instrument>();
        }
        //public List<int> InstrumentIds { get; set;}
        public int CreatedInstrument { get; set; }
        public List<Instrument> PlayedInstruments { get; set; }
    }
}
