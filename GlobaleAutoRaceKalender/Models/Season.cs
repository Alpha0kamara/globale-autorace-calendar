using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GlobaleAutoRaceKalender.Models
{
    public class Season : IValidatableObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SeriesId { get; set; }
        [JsonIgnore]
        public Series Series { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set;}
        [JsonIgnore]
        public ICollection<Race> Races { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
           if(EndDate <= StartDate)
            {
                yield return new ValidationResult("EndDate must be after the StartDate.", new[] { nameof(StartDate), nameof(EndDate) });
            }
        }
    }
}
