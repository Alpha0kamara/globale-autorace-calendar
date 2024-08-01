using System.Collections.Generic;

namespace GlobaleAutoRaceKalender.Models
{
    public class Circuit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public int Length { get; set; }
        public ICollection<Race> Races { get; set; }
    }
}
