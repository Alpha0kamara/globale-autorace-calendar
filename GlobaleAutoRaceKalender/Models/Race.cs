using System;
using System.Collections.Generic;

namespace GlobaleAutoRaceKalender.Models
{
    public class Race
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SeasonId { get; set; }
        public Season Season { get; set; }
        public int CircuitId { get; set; }
        public Circuit Circuit { get; set; }
        public DateTime StartTIme { get; set; }
        public DateTime EndTime { get; set; }
        public ICollection<RaceEntry> RaceEntries { get; set; }
        
    }
}
