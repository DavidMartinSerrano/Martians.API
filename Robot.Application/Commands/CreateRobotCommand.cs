using MediatR;
using Robot.Application.Responses;
using Robot.Core.Entities;
using Robot.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Robot.Application.Commands
{
    public class UpdateRobotCommand : IRequest<RobotResponse>
    {
        public Guid Id { get; set; }
        public CoordinatesEntity Coordinates { get; set; }

        public Orientation Orientation { get; set; }
    }
}
