using BookingAppDio.Flight.API.Application.GetFlightById;
using Mapster;

namespace BookingAppDio.Flight.API.Dtos.Mappings
{
    public class FlightMapping : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Domain.Flights.Models.Flight, FlightResponseDto>();
            config.NewConfig<GetFlightByIdQuery, FlightResponseDto>();

        }
    }
}
