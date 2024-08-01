using System.Collections.Generic;

namespace GlobaleAutoRaceKalender.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<RaceEntry> RaceEntries { get; set; }
    }
}
