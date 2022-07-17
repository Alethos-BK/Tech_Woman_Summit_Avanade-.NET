using BookingAppDio.Core.Data;
using System.Data.Common;

namespace BookingAppDio.Booking.Domain.Interfaces
{
    public interface IBookingRepository : IRepository<Models.Booking>
    {
        Task<Models.Booking> GetById(Guid id);
        void Add(Models.Booking booking);
        void Update(Models.Booking booking);

        DbConnection GetConnection();
    }
}
