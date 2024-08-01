namespace GlobaleAutoRaceKalender.Models
{
    public class RaceEntry
    {
        public int Id { get; set; }
        public int RaceId { get; set; }

        public Race Race { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int PilotId { get; set; }
        public Pilot Pilot { get; set; }
    }
}
