using GlobaleAutoRaceKalender.Enums;
using GlobaleAutoRaceKalender.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace GlobaleAutoRaceKalender.Configuration
{
    public static class SeedDataExtension
    {
        public static void SeedData(this ModelBuilder builder)
        {
            #region PilotSeed
            builder.Entity<Pilot>().HasData(
                new Pilot
                {
                    Id = 1,
                    LicenseNumber = "LIC123456",
                    FirstName = "Alpha",
                    LastName = "Kamara",
                    NickName = "Hammertime",
                    Gender = PilotGender.M,
                    DateOfBirth = new DateTime(1985, 1, 7),
                    Weight = 73,
                    Height = 174,
                    PhotoPath = "/images/pilots/alpha.jpg"
                },
                new Pilot
                {
                    Id = 2,
                    LicenseNumber = "LIC654321",
                    FirstName = "Max",
                    LastName = "Verstappen",
                    NickName = "Mad Max",
                    Gender = PilotGender.M,
                    DateOfBirth = new DateTime(1997, 9, 30),
                    Weight = 72,
                    Height = 180,
                    PhotoPath = "/images/pilots/max_verstappen.jpg"
                },
                new Pilot
                {
                    Id = 3,
                    LicenseNumber = "LIC987654",
                    FirstName = "Lando",
                    LastName = "Norris",
                    NickName = "Lando",
                    Gender = PilotGender.M,
                    DateOfBirth = new DateTime(1999, 11, 13),
                    Weight = 68,
                    Height = 170,
                    PhotoPath = "/images/pilots/lando_norris.jpg"
                });

            #endregion

            #region CircuitSeed
            builder.Entity<Circuit>().HasData(
                new Circuit
                {
                    Id = 1,
                    Name = "Grand Prix of Monaco",
                    Country = "Monaco",
                    City = "Monte Carlo",
                    Address = "Circuit de Monaco",
                    PostalCode = "98000",
                    Length = 3340
                },
                new Circuit
                {
                    Id = 2,
                    Name = "Silverstone Grand Prix",
                    Country = "UK",
                    City = "Silverstone",
                    Address = "Silverstone Circuit",
                    PostalCode = "NN12 8TN",
                    Length = 5891 // Length in meters
                },
                new Circuit
                {
                    Id = 3,
                    Name = "Australian Grand Prix",
                    Country = "Australia",
                    City = "Melbourne",
                    Address = "Albert Park Circuit",
                    PostalCode = "3004",
                    Length = 5303 // Length in meters
                });
            #endregion

            #region TeamSeed
            builder.Entity<Team>().HasData(
                new Team
                {
                    Id = 1,
                    Name = "AlphaTeam"
                },
                new Team
                {
                    Id = 2,
                    Name = "BetaTeam"
                },
                new Team
                {
                    Id = 3,
                    Name = "IsmailTeam"
                }
                );
            #endregion

            #region SeriesSeed
            builder.Entity<Series>().HasData(
                new Series
                {
                    Id = 1,
                    Name = "FIA Formula One World Championship",
                    StartDate = new DateTime(2024, 3, 17),
                    EndDate = new DateTime(2024, 12, 1),
                    SortOrder = 1
                },
                new Series
                {
                    Id = 2,
                    Name = "FIA Formula E World Championship",
                    StartDate = new DateTime(2024, 1, 13),
                    EndDate = new DateTime(2024, 9, 15),
                    SortOrder = 2
                },
                new Series
                {
                    Id = 3,
                    Name = "FIA World Endurance Championship",
                    StartDate = new DateTime(2024, 3, 15),
                    EndDate = new DateTime(2024, 11, 2),
                    SortOrder = 3
                },
                new Series
                {
                    Id = 4,
                    Name = "IndyCar Series",
                    StartDate = new DateTime(2024, 3, 10),
                    EndDate = new DateTime(2024, 9, 22),
                    SortOrder = 4
                },
                new Series
                {
                    Id = 5,
                    Name = "MotoGP World Championship",
                    StartDate = new DateTime(2024, 3, 10),
                    EndDate = new DateTime(2024, 11, 17),
                    SortOrder = 5
                }
                );

            #endregion

            #region SeasonSeed
            builder.Entity<Season>().HasData(
                new Season
                {
                    Id = 1,
                    Name = "2024 Formula One Season",
                    SeriesId = 1, // FIA Formula One World Championship
                    StartDate = new DateTime(2024, 3, 17),
                    EndDate = new DateTime(2024, 12, 1),
                    IsActive = true
                },
                new Season
                {
                    Id = 2,
                    Name = "2024 Formula E Season",
                    SeriesId = 2, // FIA Formula E World Championship
                    StartDate = new DateTime(2024, 1, 13),
                    EndDate = new DateTime(2024, 9, 15),
                    IsActive = true
                },
                new Season
                {
                    Id = 3,
                    Name = "2024 WEC Season",
                    SeriesId = 3, // FIA World Endurance Championship
                    StartDate = new DateTime(2024, 3, 15),
                    EndDate = new DateTime(2024, 11, 2),
                    IsActive = true
                },
                new Season
                {
                    Id = 4,
                    Name = "2024 IndyCar Season",
                    SeriesId = 4, // IndyCar Series
                    StartDate = new DateTime(2024, 3, 10),
                    EndDate = new DateTime(2024, 9, 22),
                    IsActive = true
                },
                new Season
                {
                    Id = 5,
                    Name = "2024 MotoGP Season",
                    SeriesId = 5, // MotoGP World Championship
                    StartDate = new DateTime(2024, 3, 10),
                    EndDate = new DateTime(2024, 11, 17),
                    IsActive = true
                });
            #endregion

            #region RaceSeed
            builder.Entity<Race>().HasData(
                new Race
                {
                    Id = 1,
                    Name = "Monaco Grand Prix 2024",
                    SeasonId = 1, // 2024 Formula One Season
                    CircuitId = 1, // Circuit de Monaco
                    StartTIme = new DateTime(2024, 5, 26, 14, 0, 0), // May 26, 2024, 2:00 PM
                    EndTime = new DateTime(2024, 5, 26, 16, 0, 0) // May 2
                },
                new Race
                {
                    Id = 2,
                    Name = "Silverstone Grand Prix 2024",
                    SeasonId = 1, // 2024 Formula One Season
                    CircuitId = 2, // Silverstone Circuit
                    StartTIme = new DateTime(2024, 7, 7, 14, 0, 0), // July 7, 2024, 2:00 PM
                    EndTime = new DateTime(2024, 7, 7, 16, 0, 0) // July 7, 2024, 4:00 PM
                },
                new Race
                {
                    Id = 3,
                    Name = "Australian Grand Prix 2024",
                    SeasonId = 1, // 2024 Formula One Season
                    CircuitId = 3, // Albert Park Circuit
                    StartTIme = new DateTime(2024, 3, 17, 5, 0, 0), // March 17, 2024, 5:00 AM
                    EndTime = new DateTime(2024, 3, 17, 7, 0, 0) // March 17, 2024, 7:00 AM
                }
                );

            #endregion

            #region RaceEntrySeed

            builder.Entity<RaceEntry>().HasData(
                new RaceEntry
                {
                    Id = 1,
                    RaceId = 1, // Monaco Grand Prix 2024
                    TeamId = 1, // Assuming Team 1
                    PilotId = 1 // Alpha
                },
                new RaceEntry
                {
                    Id = 2,
                    RaceId = 2, // Silverstone Grand Prix 2024
                    TeamId = 2, // Assuming Team 2
                    PilotId = 2 // Max Verstappen
                },
                new RaceEntry
                {
                    Id = 3,
                    RaceId = 3, // Australian Grand Prix 2024
                    TeamId = 3, // Assuming Team 3
                    PilotId = 3 // Lando Norris
                },
                new RaceEntry
                {
                    Id = 4,
                    RaceId = 2, // Silverstone Grand Prix 2024
                    TeamId = 1, // Assuming Team 1 (same team as above)
                    PilotId = 1 // Lewis Hamilton
                },
                new RaceEntry
                {
                    Id = 5,
                    RaceId = 3, // Australian Grand Prix 2024
                    TeamId = 2, // Assuming Team 2 (same team as above)
                    PilotId = 2 // Max Verstappen
                },
                new RaceEntry
                {
                    Id = 6,
                    RaceId = 1, // Monaco Grand Prix 2024
                    TeamId = 3, // Assuming Team 3 (same team as above)
                    PilotId = 3 // Lando Norris
                });
            #endregion
        }
    }
}
