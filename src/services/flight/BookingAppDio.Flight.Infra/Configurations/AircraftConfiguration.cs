using BookingAppDio.Flight.Domain.Aircrafts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookingAppDio.Flight.Infra.Configurations
{
    public class AircraftConfiguration : IEntityTypeConfiguration<Aircraft>
    {
        public void Configure(EntityTypeBuilder<Aircraft> builder)
        {
            builder.ToTable("Aircraft");
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedNever();
        }
    }
}
