using BookingAppDio.Core.CQRS;
using BookingAppDio.Flight.API.Dtos;

namespace BookingAppDio.Flight.API.Application.ReserveSeat
{
    public record ReserveSeatCommand(long Id, string SeatNumber) : ICommand<SeatResponseDto>;

}
