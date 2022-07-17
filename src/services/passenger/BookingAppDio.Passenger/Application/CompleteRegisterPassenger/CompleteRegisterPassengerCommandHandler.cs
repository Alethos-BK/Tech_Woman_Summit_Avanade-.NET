using BookingAppDio.Core.CQRS;
using BookingAppDio.Passenger.Data;
using BookingAppDio.Passenger.Dtos;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace BookingAppDio.Passenger.Application.CompleteRegisterPassenger
{
    public class CompleteRegisterPassengerCommandHandler : ICommandHandler<CompleteRegisterPassengerCommand, PassengerResponseDto>
    {
        private readonly PassengerDbContext _passengerDbContext;
        private readonly IMapper _mapper;


        public CompleteRegisterPassengerCommandHandler(IMapper mapper, PassengerDbContext passengerDbContext)
        {
            _mapper = mapper;
            _passengerDbContext = passengerDbContext;
        }

        public async Task<PassengerResponseDto> Handle(CompleteRegisterPassengerCommand request,
            CancellationToken cancellationToken)
        {
            var passenger = await _passengerDbContext.Passengers.AsNoTracking().
                SingleOrDefaultAsync(x => x.PassportNumber == request.PassportNumber,
                    cancellationToken);

            if (passenger is null)
            {
                throw new NotImplementedException();
            }

            var passengerEntity = passenger.CompleteRegistrationPassenger(
                passenger.Id,
                passenger.Name,
                passenger.PassportNumber,
                passenger.PassengerType,
                passenger.Age);

            _passengerDbContext.SaveChanges();

            var passengerUpdate = _passengerDbContext.Passengers.Update(passengerEntity);

            return _mapper.Map<PassengerResponseDto>(passengerUpdate.Entity);
        }
    }
}
