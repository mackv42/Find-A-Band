using FindABand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.ViewModels
{
    public class BandDetailsViewModel
    {
        public BandDetailsViewModel()
        {
            inviteId = null;
        }
        public Band band { get; set; }
        public int? inviteId { get; set; }
    }
}
