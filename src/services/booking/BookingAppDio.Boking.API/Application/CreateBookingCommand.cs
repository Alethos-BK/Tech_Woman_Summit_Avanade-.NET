
using BookingAppDio.Boking.API.Dtos;
using BookingAppDio.Core.CQRS;

namespace BookingAppDio.Boking.API.Application
{
    public record CreateBookingCommand(long PassengerId, long FlightId, string Description) : ICommand<CreateReservationResponseDto>
    {
        public Guid Id { get; init; } = Guid.NewGuid();

    }
}
