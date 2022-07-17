using BookingAppDio.Core.CQRS;
using BookingAppDio.Passenger.Dtos;

namespace BookingAppDio.Passenger.Application.GetPassengerById
{
    public record GetPassengerByIdQuery(long Id) : IQuery<PassengerResponseDto>;
}
