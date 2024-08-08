using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GlobaleAutoRaceKalender.Models
{
    public class Series
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int SortOrder { get; set; }
        public bool IsActief => EndDate == null;
        [JsonIgnore]
        public ICollection<Season> Seasons { get; set; }

    }
}
