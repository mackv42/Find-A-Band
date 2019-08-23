using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.Models
{
    public class Instrument
    {
        public Instrument()
        {

        }

        public Instrument( string n)
        {
            this.Name = n;
        }
        [Key]
        public int InstrumentId { get; set; }
        public string Name { get; set; }
    }
}
