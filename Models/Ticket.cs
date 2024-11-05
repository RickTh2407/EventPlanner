using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventPlanner.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        [Required]
        public int EventId { get; set; }
        public int ParticipantId { get; set; }
        public bool Payed { get; set; }
        public Event Event { get; set; }
        public Participant Participant { get; set; }

        public void BookTicket()
        {
            double count = 0.00;
            double totalPrice = Event.PricePP * count;

            
        }
    }
}