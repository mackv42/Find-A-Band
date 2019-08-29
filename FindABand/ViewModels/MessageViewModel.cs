using FindABand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.ViewModels
{
    public class MessageViewModel
    {
        public MessageViewModel()
        {
            Messages = new List<Message>();
        }
        
        public List<Message> Messages { get; set; }
        public string MyId { get; set; }
        public string UserId { get; set; }
    }
}
