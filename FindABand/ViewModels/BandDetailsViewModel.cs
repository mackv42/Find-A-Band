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
            band = new Band();
            band.Songs = new List<BandSongSample>();
            inviteId = null;
        }
        public Band band { get; set; }
        public int? inviteId { get; set; }
    }
}
