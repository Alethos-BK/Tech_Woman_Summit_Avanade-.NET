using BookingAppDio.Core.ModelsAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppDio.Flight.Domain.Seats.Models
{
    public class Seat : Aggregate<long>
    {
        public string SeatNumber { get; private set; }
        public SeatType Type { get; private set; }
        public SeatClass Class { get; private set; }
        public long FlightId { get; private set; }

        public static Seat Create(long id, string v, SeatType seatType, SeatClass @class, long flightId)
        {
            return new Seat
            {
                Id = id,
                Type = seatType,
                Class = @class,
                FlightId = flightId
            };

        }

        public Task<Seat> ReserveSeat(Seat seat)
        {
            seat.IsDeleted = true;
            seat.LastModified = DateTime.UtcNow;

            return Task.FromResult(this);
        }
    }
}
