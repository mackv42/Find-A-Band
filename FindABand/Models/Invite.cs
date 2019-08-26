using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.Models
{
    public class Invite
    {
        [Key]
        public int Id { get; set; }
        //band that sent invite
        public int SenderId { get; set; }
        //Musician that recieved invite
        public int Recipient { get; set; }
        public string Message { get; set; }
    }
}
