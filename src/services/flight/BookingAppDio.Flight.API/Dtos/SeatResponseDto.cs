using BookingAppDio.Flight.Domain.Seats.Models;

namespace BookingAppDio.Flight.API.Dtos
{
    public class SeatResponseDto
    {
        public long Id { get; init; }
        public string SeatNumber { get; init; }
        public SeatType Type { get; init; }
        public SeatClass Class { get; init; }
        public long FlightId { get; init; }
    }
}
