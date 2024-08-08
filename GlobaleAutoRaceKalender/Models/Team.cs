using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GlobaleAutoRaceKalender.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public ICollection<RaceEntry> RaceEntries { get; set; }
    }
}
