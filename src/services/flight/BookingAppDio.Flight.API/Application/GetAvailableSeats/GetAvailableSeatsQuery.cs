using BookingAppDio.Core.CQRS;
using BookingAppDio.Flight.API.Dtos;

namespace BookingAppDio.Flight.API.Application.GetAvailableSeats
{
    public record GetAvailableSeatsQuery(long Id) : IQuery<IEnumerable<SeatResponseDto>>;

}
