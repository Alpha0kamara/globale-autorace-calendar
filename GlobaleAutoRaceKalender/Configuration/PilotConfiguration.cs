using GlobaleAutoRaceKalender.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GlobaleAutoRaceKalender.Configuration
{
    public class PilotConfiguration : IEntityTypeConfiguration<Pilot>
    {
        public void Configure(EntityTypeBuilder<Pilot> builder)
        {
            builder.Property(x => x.LicenseNumber).IsRequired();
            builder.Property(x => x.Gender).IsRequired();
        }
    }
}
