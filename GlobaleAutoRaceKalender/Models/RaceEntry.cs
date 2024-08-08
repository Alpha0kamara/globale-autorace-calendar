using System.Text.Json.Serialization;

namespace GlobaleAutoRaceKalender.Models
{
    public class RaceEntry
    {
        public int Id { get; set; }
        public int RaceId { get; set; }
        [JsonIgnore]
        public Race Race { get; set; }
        public int TeamId { get; set; }
        [JsonIgnore]
        public Team Team { get; set; }
        public int PilotId { get; set; }
        [JsonIgnore]
        public Pilot Pilot { get; set; }
    }
}
