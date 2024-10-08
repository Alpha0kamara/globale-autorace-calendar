using GlobaleAutoRaceKalender.Configuration;
using GlobaleAutoRaceKalender.Enums;
using GlobaleAutoRaceKalender.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace GlobaleAutoRaceKalender.Dal
{
    public class GlobalAutoRaceCalendarContext : DbContext
    {
        public GlobalAutoRaceCalendarContext(DbContextOptions<GlobalAutoRaceCalendarContext> options)
            : base(options)
        {
        }

        public DbSet<Pilot> Pilots { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Circuit> Circuits { get; set; }
        public DbSet<RaceEntry> RaceEntries { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new SeasonConfiguration());
            modelBuilder.ApplyConfiguration(new RaceConfiguration());
            modelBuilder.ApplyConfiguration(new RaceEntryConfiguration());
            //modelBuilder.SeedData();
        }

        
    }
}
 