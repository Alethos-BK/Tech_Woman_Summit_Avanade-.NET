using BookingAppDio.Core.CQRS;
using BookingAppDio.Flight.API.Dtos;
using BookingAppDio.Flight.Infra.Context;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace BookingAppDio.Flight.API.Application.GetAvailableSeats
{

    public class GetAvailableSeatsQueryHandler : IQueryHandler<GetAvailableSeatsQuery, IEnumerable<SeatResponseDto>>
    {
        private readonly FlightDbContext _flightDbContext;
        private readonly IMapper _mapper;


        public GetAvailableSeatsQueryHandler(IMapper mapper, FlightDbContext flightDbContext)
        {
            _mapper = mapper;
            _flightDbContext = flightDbContext;
        }

        public async Task<IEnumerable<SeatResponseDto>> Handle(GetAvailableSeatsQuery request,
            CancellationToken cancellationToken)
        {
            var flight = await _flightDbContext.Flights.Where(x => x.Id == request.Id && !x.IsDeleted).ToListAsync(cancellationToken);

            if (!flight.Any())
            {
                throw new NotImplementedException();
            }

            return _mapper.Map<List<SeatResponseDto>>(flight);
        }
    }
}
