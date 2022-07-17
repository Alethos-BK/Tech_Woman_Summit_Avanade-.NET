using BookingAppDio.Bus.Contracts;
using Mapster;
using MapsterMapper;
using MassTransit;
using MediatR;

namespace BookingAppDio.Flight.API.Application.GetAvailableSeats
{
    public class GetAvailableSeatConsumer : IConsumer<GetAvailableSeatsById>
    {
        private IMediator _mediator;
        private readonly IMapper _mapper;

        public GetAvailableSeatConsumer(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        public async Task Consume(ConsumeContext<GetAvailableSeatsById> context)
        {
            var flightId = context.Message.FlightId;
            var query = new GetAvailableSeatsQuery(flightId);

            var seatList = await _mediator.Send(query);

            var message = seatList.First();

            await context.RespondAsync<SeatResponse>(message);
        }
    }
}
