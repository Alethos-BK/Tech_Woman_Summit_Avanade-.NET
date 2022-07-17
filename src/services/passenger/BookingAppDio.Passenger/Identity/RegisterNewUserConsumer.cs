using BookingAppDio.Bus.Contracts;
using BookingAppDio.Core.Generator;
using BookingAppDio.Passenger.Data;
using MassTransit;

namespace BookingAppDio.Passenger.Identity
{
    public class RegisterNewUserConsumer : IConsumer<UserCreated>
    {
        private readonly PassengerDbContext _passengerDbCOntext;

        public RegisterNewUserConsumer(PassengerDbContext passengerDb)
        {
            _passengerDbCOntext = passengerDb;
        }
        public async Task Consume(ConsumeContext<UserCreated> context)
        {
            var passenger = Passenger.Passengers.Models.Passenger.Create(SnowFlakeIdGenerator.NewId(),
                context.Message.Name, context.Message.PassportNumber);
                
            await _passengerDbCOntext.AddAsync(passenger);
            await _passengerDbCOntext.SaveChangesAsync();
        }
    }
}
