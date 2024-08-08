using GlobaleAutoRaceKalender.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GlobaleAutoRaceKalender.Configuration
{
    public class SeasonConfiguration : IEntityTypeConfiguration<Season>
    {
        public void Configure(EntityTypeBuilder<Season> builder)
        {
            builder.HasOne(s => s.Series)
                .WithMany(s => s.Seasons)
                .HasForeignKey(p => p.SeriesId)
                .OnDelete(deleteBehavior: DeleteBehavior.Restrict);

            builder.Property(s => s.SeriesId)
                .IsRequired();

            builder.Property(n => n.Name)
                .IsRequired();

            builder.Property(d => d.StartDate)
                .IsRequired();

            builder.Property(d => d.EndDate)
             .IsRequired();

            builder.Property(a => a.IsActive)
                .IsRequired();
        }
    }
}
