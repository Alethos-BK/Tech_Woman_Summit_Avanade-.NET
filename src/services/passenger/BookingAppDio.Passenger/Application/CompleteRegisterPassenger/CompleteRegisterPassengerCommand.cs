using BookingAppDio.Core.CQRS;
using BookingAppDio.Core.Generator;
using BookingAppDio.Passenger.Dtos;
using BookingAppDio.Passenger.Passengers.Models;

namespace BookingAppDio.Passenger.Application.CompleteRegisterPassenger
{
    public record CompleteRegisterPassengerCommand(string PassportNumber,
        PassengerType PassengerType, int Age) :ICommand<PassengerResponseDto>
    {
        public long Id { get; set; } = SnowFlakeIdGenerator.NewId();
    }

}
