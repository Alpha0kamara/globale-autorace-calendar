using GlobaleAutoRaceKalender.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GlobaleAutoRaceKalender.Configuration
{
    public class RaceConfiguration : IEntityTypeConfiguration<Race>
    {
        public void Configure(EntityTypeBuilder<Race> builder)
        {
            builder.HasOne(c => c.Circuit)
                .WithMany(r => r.Races)
                .HasForeignKey(c => c.CircuitId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(s => s.Season)
                .WithMany(r => r.Races)
                .HasForeignKey(s => s.SeasonId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(s => s.SeasonId)
                .IsRequired();

            builder.Property(n => n.Name)
                .IsRequired();

            builder.Property(s => s.StartTIme)
                .IsRequired();

            builder.Property(e => e.EndTime)
                .IsRequired();
        }
    }
}
