using BookingAppDio.Core.Data;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BookingAppDio.Passenger.Data
{

    public class PassengerDbContext : DbContext, IUnitOfWork
    {
        public PassengerDbContext(DbContextOptions<PassengerDbContext> options) : base(options)
        {

        }

        public DbSet<Passengers.Models.Passenger> Passengers => Set<Passengers.Models.Passenger>();

        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }

    }
}
