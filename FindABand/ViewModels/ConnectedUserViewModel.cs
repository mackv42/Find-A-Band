using FindABand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.ViewModels
{
    public class ConnectedUserViewModel
    {
        public ConnectedUserViewModel()
        {
            ConnectedAccounts = new List<UserAccount>();
            UserBands = new List<Band>();
            AcceptedInvites = new List<AcceptedInvite>();
        }
        public List<AcceptedInvite> AcceptedInvites{ get; set; }
        public List<Band> UserBands { get; set; }
        public List<UserAccount> ConnectedAccounts {get; set;}
    }
}
