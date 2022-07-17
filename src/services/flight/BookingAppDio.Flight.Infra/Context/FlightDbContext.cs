using BookingAppDio.Flight.Domain.Aircrafts.Models;
using BookingAppDio.Flight.Domain.Airports.Models;
using BookingAppDio.Flight.Domain.Seats.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BookingAppDio.Flight.Infra.Context
{
    public class FlightDbContext : DbContext
    {
        public FlightDbContext(DbContextOptions<FlightDbContext> options) : base(
             options)
        {
        }

        public DbSet<Domain.Flights.Models.Flight> Flights => Set<Domain.Flights.Models.Flight>();
        public DbSet<Airport> Airports => Set<Airport>();
        public DbSet<Aircraft> Aircraft => Set<Aircraft>();
        public DbSet<Seat> Seats => Set<Seat>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}
