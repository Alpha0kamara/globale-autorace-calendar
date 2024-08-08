using GlobaleAutoRaceKalender.Enums;
using System.ComponentModel.DataAnnotations;
using System;

namespace GlobaleAutoRaceKalender.DTO
{
    public class PilotAddDTO
    {
        public int Id { get; set; }
        [Required]
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
    }
}
