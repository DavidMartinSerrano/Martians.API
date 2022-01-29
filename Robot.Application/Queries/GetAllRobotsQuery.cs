using MediatR;
using Robot.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Robot.Application.Queries
{
    public class GetAllRobotsQuery : IRequest<List<RobotResponse>>
    {

    }
}
