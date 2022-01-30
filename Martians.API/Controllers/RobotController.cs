using Robot.Application.Commands;
using Robot.Application.Queries;
using Robot.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Martians.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RobotController : ControllerBase
    {
        private readonly IMediator _mediator;
        public RobotController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<RobotResponse>> Get()
        {
            return await _mediator.Send<List<RobotResponse>>(new GetAllRobotsQuery());
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<RobotResponse>> Post([FromBody] CreateRobotCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
