using FindABand.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int? MyProfileId { get; set; }
        public int? MyBandId { get; set; }
        public int? UserId { get; set; }
        public int? BandId { get; set; }

        public string Name { get; set; }
    }
}
