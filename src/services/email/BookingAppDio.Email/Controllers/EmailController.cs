﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookingAppDio.Email.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EmailController(IMediator mediator)
        {
            _mediator = mediator;
        }

    }
}
