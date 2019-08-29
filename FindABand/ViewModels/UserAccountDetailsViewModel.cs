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
        public UserAccount Account { get; set; }
        public List<Band> Bands { get; set; }
    }
}
