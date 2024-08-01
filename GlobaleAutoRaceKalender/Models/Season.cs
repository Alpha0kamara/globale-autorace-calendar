using System;
using System.Collections.Generic;

namespace GlobaleAutoRaceKalender.Models
{
    public class Season
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SeriesId { get; set; }
        public Series Series { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set;}
        public ICollection<Race> Races { get; set; }

    }
}
