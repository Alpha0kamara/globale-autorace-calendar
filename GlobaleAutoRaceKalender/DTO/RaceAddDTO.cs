using GlobaleAutoRaceKalender.Models;
using System;

namespace GlobaleAutoRaceKalender.DTO
{
    public class RaceAddDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SeasonId { get; set; }
        public int CircuitId { get; set; }
        public DateTime StartTIme { get; set; }
        public DateTime EndTime { get; set; }
    }
}
