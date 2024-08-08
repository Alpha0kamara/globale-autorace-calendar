﻿// <auto-generated />
using System;
using GlobaleAutoRaceKalender.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GlobaleAutoRaceKalender.Migrations
{
    [DbContext(typeof(GlobalAutoRaceCalendarContext))]
    [Migration("20240808215947_AddedDataSeed")]
    partial class AddedDataSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GlobaleAutoRaceKalender.Models.Circuit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Circuits");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Circuit de Monaco",
                            City = "Monte Carlo",
                            Country = "Monaco",
                            Length = 3340,
                            Name = "Grand Prix of Monaco",
                            PostalCode = "98000"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Silverstone Circuit",
                            City = "Silverstone",
                            Country = "UK",
                            Length = 5891,
                            Name = "Silverstone Grand Prix",
                            PostalCode = "NN12 8TN"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Albert Park Circuit",
                            City = "Melbourne",
                            Country = "Australia",
                            Length = 5303,
                            Name = "Australian Grand Prix",
                            PostalCode = "3004"
                        });
                });

            modelBuilder.Entity("GlobaleAutoRaceKalender.Models.Pilot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<int?>("Height")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicenseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NickName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pilots");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(1985, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Alpha",
                            Gender = 0,
                            Height = 174,
                            LastName = "Kamara",
                            LicenseNumber = "LIC123456",
                            NickName = "Hammertime",
                            PhotoPath = "/images/pilots/alpha.jpg",
                            Weight = 73
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1997, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Max",
                            Gender = 0,
                            Height = 180,
                            LastName = "Verstappen",
                            LicenseNumber = "LIC654321",
                            NickName = "Mad Max",
                            PhotoPath = "/images/pilots/max_verstappen.jpg",
                            Weight = 72
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1999, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Lando",
                            Gender = 0,
                            Height = 170,
                            LastName = "Norris",
                            LicenseNumber = "LIC987654",
                            NickName = "Lando",
                            PhotoPath = "/images/pilots/lando_norris.jpg",
                            Weight = 68
                        });
                });

            modelBuilder.Entity("GlobaleAutoRaceKalender.Models.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CircuitId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeasonId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTIme")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CircuitId");

                    b.HasIndex("SeasonId");

                    b.ToTable("Races");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CircuitId = 1,
                            EndTime = new DateTime(2024, 5, 26, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Monaco Grand Prix 2024",
                            SeasonId = 1,
                            StartTIme = new DateTime(2024, 5, 26, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CircuitId = 2,
                            EndTime = new DateTime(2024, 7, 7, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Silverstone Grand Prix 2024",
                            SeasonId = 1,
                            StartTIme = new DateTime(2024, 7, 7, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CircuitId = 3,
                            EndTime = new DateTime(2024, 3, 17, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Australian Grand Prix 2024",
                            SeasonId = 1,
                            StartTIme = new DateTime(2024, 3, 17, 5, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("GlobaleAutoRaceKalender.Models.RaceEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PilotId")
                        .HasColumnType("int");

                    b.Property<int>("RaceId")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PilotId");

                    b.HasIndex("RaceId");

                    b.HasIndex("TeamId");

                    b.ToTable("RaceEntries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PilotId = 1,
                            RaceId = 1,
                            TeamId = 1
                        },
                        new
                        {
                            Id = 2,
                            PilotId = 2,
                            RaceId = 2,
                            TeamId = 2
                        },
                        new
                        {
                            Id = 3,
                            PilotId = 3,
                            RaceId = 3,
                            TeamId = 3
                        },
                        new
                        {
                            Id = 4,
                            PilotId = 1,
                            RaceId = 2,
                            TeamId = 1
                        },
                        new
                        {
                            Id = 5,
                            PilotId = 2,
                            RaceId = 3,
                            TeamId = 2
                        },
                        new
                        {
                            Id = 6,
                            PilotId = 3,
                            RaceId = 1,
                            TeamId = 3
                        });
                });

            modelBuilder.Entity("GlobaleAutoRaceKalender.Models.Season", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeriesId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SeriesId");

                    b.ToTable("Seasons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EndDate = new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "2024 Formula One Season",
                            SeriesId = 1,
                            StartDate = new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            EndDate = new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "2024 Formula E Season",
                            SeriesId = 2,
                            StartDate = new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            EndDate = new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "2024 WEC Season",
                            SeriesId = 3,
                            StartDate = new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            EndDate = new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "2024 IndyCar Season",
                            SeriesId = 4,
                            StartDate = new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            EndDate = new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "2024 MotoGP Season",
                            SeriesId = 5,
                            StartDate = new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            EndDate = new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "2024 NASCAR Season",
                            SeriesId = 6,
                            StartDate = new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("GlobaleAutoRaceKalender.Models.Series", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Series");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EndDate = new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "FIA Formula One World Championship",
                            SortOrder = 1,
                            StartDate = new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            EndDate = new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "FIA Formula E World Championship",
                            SortOrder = 2,
                            StartDate = new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            EndDate = new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "FIA World Endurance Championship",
                            SortOrder = 3,
                            StartDate = new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            EndDate = new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "IndyCar Series",
                            SortOrder = 4,
                            StartDate = new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            EndDate = new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "MotoGP World Championship",
                            SortOrder = 5,
                            StartDate = new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("GlobaleAutoRaceKalender.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "AlphaTeam"
                        },
                        new
                        {
                            Id = 2,
                            Name = "BetaTeam"
                        },
                        new
                        {
                            Id = 3,
                            Name = "IsmailTeam"
                        });
                });

            modelBuilder.Entity("GlobaleAutoRaceKalender.Models.Race", b =>
                {
                    b.HasOne("GlobaleAutoRaceKalender.Models.Circuit", "Circuit")
                        .WithMany("Races")
                        .HasForeignKey("CircuitId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("GlobaleAutoRaceKalender.Models.Season", "Season")
                        .WithMany("Races")
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Circuit");

                    b.Navigation("Season");
                });

            modelBuilder.Entity("GlobaleAutoRaceKalender.Models.RaceEntry", b =>
                {
                    b.HasOne("GlobaleAutoRaceKalender.Models.Pilot", "Pilot")
                        .WithMany("RaceEntries")
                        .HasForeignKey("PilotId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("GlobaleAutoRaceKalender.Models.Race", "Race")
                        .WithMany("RaceEntries")
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("GlobaleAutoRaceKalender.Models.Team", "Team")
                        .WithMany("RaceEntries")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Pilot");

                    b.Navigation("Race");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("GlobaleAutoRaceKalender.Models.Season", b =>
                {
                    b.HasOne("GlobaleAutoRaceKalender.Models.Series", "Series")
                        .WithMany("Seasons")
                        .HasForeignKey("SeriesId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Series");
                });

            modelBuilder.Entity("GlobaleAutoRaceKalender.Models.Circuit", b =>
                {
                    b.Navigation("Races");
                });

            modelBuilder.Entity("GlobaleAutoRaceKalender.Models.Pilot", b =>
                {
                    b.Navigation("RaceEntries");
                });

            modelBuilder.Entity("GlobaleAutoRaceKalender.Models.Race", b =>
                {
                    b.Navigation("RaceEntries");
                });

            modelBuilder.Entity("GlobaleAutoRaceKalender.Models.Season", b =>
                {
                    b.Navigation("Races");
                });

            modelBuilder.Entity("GlobaleAutoRaceKalender.Models.Series", b =>
                {
                    b.Navigation("Seasons");
                });

            modelBuilder.Entity("GlobaleAutoRaceKalender.Models.Team", b =>
                {
                    b.Navigation("RaceEntries");
                });
#pragma warning restore 612, 618
        }
    }
}
