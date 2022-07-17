using BookingAppDio.Core.CQRS;
using BookingAppDio.Passenger.Data;
using BookingAppDio.Passenger.Dtos;
using MapsterMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookingAppDio.Passenger.Application.GetPassengerById
{
    public class GetPassengerByIdQueryHandler : IQueryHandler<GetPassengerByIdQuery, PassengerResponseDto>
    {
        private readonly PassengerDbContext _passenherDbContext;
        private readonly IMapper _mapper;


        public GetPassengerByIdQueryHandler(IMapper mapper, PassengerDbContext passenherDbContext)
        {
            _mapper = mapper;
            _passenherDbContext = passenherDbContext;
        }

        public async Task<PassengerResponseDto> Handle(GetPassengerByIdQuery request,
            CancellationToken cancellationToken)
        {
            var passenger = await _passenherDbContext.Passengers.SingleOrDefaultAsync(x => x.Id == request.Id
                 && !x.IsDeleted, cancellationToken);

            if (passenger is null)
            {
                throw new NotImplementedException();
            }

            return _mapper.Map<PassengerResponseDto>(passenger!);
        }
    }
}
