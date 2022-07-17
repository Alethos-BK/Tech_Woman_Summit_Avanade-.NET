using BookingAppDio.Passenger.Application.CompleteRegisterPassenger;
using BookingAppDio.Passenger.Application.GetPassengerById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookingAppDio.Passenger.Controllers
{
    [Route("api/[passenger]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PassengerController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> GetById([FromRoute] GetPassengerByIdQuery query,
           CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(query, cancellationToken);
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CompleteRegisterPassenger([FromBody] CompleteRegisterPassengerCommand command,
            CancellationToken cancellationToken)

        {
            var result = await _mediator.Send(command, cancellationToken);
            return Ok(result);
        }
    }
}
