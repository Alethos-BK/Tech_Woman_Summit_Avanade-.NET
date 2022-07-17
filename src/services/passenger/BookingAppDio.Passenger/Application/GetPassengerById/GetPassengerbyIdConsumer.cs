using BookingAppDio.Bus.Contracts;
using Mapster;
using MassTransit;
using MediatR;

namespace BookingAppDio.Passenger.Application.GetPassengerById
{
    public class GetPassengerbyIdConsumer : IConsumer<GetPassengerByIdRequest>
    {
        private IMediator _mediator;

        public GetPassengerbyIdConsumer(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task Consume(ConsumeContext<GetPassengerByIdRequest> context)
        {
            var query = new GetPassengerByIdQuery(context.Message.PassengerId);

            var passengerResponseDto = await _mediator.Send(query);

            var result = passengerResponseDto.Adapt<PassengerResponse>();

            await context.RespondAsync(result);
        }
    }
}
