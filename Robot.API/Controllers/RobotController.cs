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


namespace Robot.API.Controllers
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


        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<RobotResponse>> UpdateRobots([FromBody] UpdateRobotCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }


        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> Delete()
        {
            var result = await _mediator.Send(new DeleteRobotsCommand());
            return Ok(result);
        }
    }
}
