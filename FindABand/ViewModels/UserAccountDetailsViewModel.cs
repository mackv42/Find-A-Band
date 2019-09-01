using FindABand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.ViewModels
{
    public class UserAccountDetailsViewModel
    {
        public UserAccountDetailsViewModel()
        {
            Bands = new List<Band>();
        }
        public int bandId { get; set; }
        public UserAccount Account { get; set; }
        public List<Band> Bands { get; set; }
        public int? inviteId { get; set; }
    }
}
