using GlobaleAutoRaceKalender.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GlobaleAutoRaceKalender.Models
{
    public class Pilot
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression("^[A-Fa-f0-9]{12}$", ErrorMessage = "License number must be 12 characters long and only contain letters and numbers.")]
        public string LicenseNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        [Required]
        public PilotGender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int? Weight { get; set; }
        public int? Height { get; set; }
        public string PhotoPath { get; set; }
        public ICollection<RaceEntry> RaceEntries { get; set; }
    }
}
