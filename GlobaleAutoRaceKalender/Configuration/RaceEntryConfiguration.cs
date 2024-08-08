using GlobaleAutoRaceKalender.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GlobaleAutoRaceKalender.Configuration
{
    public class RaceEntryConfiguration : IEntityTypeConfiguration<RaceEntry>
    {
        public void Configure(EntityTypeBuilder<RaceEntry> builder)
        {
            builder.HasOne(r => r.Race)
                .WithMany(e => e.RaceEntries)
                .HasForeignKey(r => r.RaceId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Pilot)
                .WithMany(r => r.RaceEntries)
                .HasForeignKey(p => p.PilotId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Team)
                .WithMany(r => r.RaceEntries)
                .HasForeignKey(t => t.TeamId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(r => r.RaceId).IsRequired();
            builder.Property(t => t.TeamId).IsRequired();
            builder.Property(p => p.PilotId).IsRequired();



        }
    }
}
