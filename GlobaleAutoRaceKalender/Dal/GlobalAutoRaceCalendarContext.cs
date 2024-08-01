using GlobaleAutoRaceKalender.Models;
using Microsoft.EntityFrameworkCore;

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
           modelBuilder.Entity<RaceEntry>()
                .HasOne(re => re.Race)
                .WithMany(r => r.RaceEntries)
                .HasForeignKey(re => re.RaceId);

            modelBuilder.Entity<RaceEntry>()
                .HasOne(re => re.Team)
                .WithMany(t => t.RaceEntries)
                .HasForeignKey(re => re.TeamId);

            modelBuilder.Entity<RaceEntry>()
                .HasOne(re => re.Pilot)
                .WithMany(p => p.RaceEntries)
                .HasForeignKey(re => re.PilotId);
        }
    }
}
