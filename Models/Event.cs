using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventPlanner.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime TimeDate { get; set; }
        public double PricePP { get; set; }
        public int MaxParticipants { get; set; }
        public int ParticipantCount { get; set; }
    }
}