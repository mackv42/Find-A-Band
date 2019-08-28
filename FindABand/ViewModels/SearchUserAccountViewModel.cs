using FindABand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.ViewModels
{
    public class SearchUserAccountViewModel
    {
        public SearchUserAccountViewModel()
        {
            userAccounts = new List<UserAccount>();
        }
        public List<UserAccount> userAccounts { get; set; }
        public int SearchQuery { get; set; }
    }
}
