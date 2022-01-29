using MediatR;
using Robot.Application.Commands;
using Robot.Application.Mappers;
using Robot.Application.Responses;
using Robot.Core.Entities;
using Robot.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Robot.Application.Handler.CommandHandlers
{
    public class CreateRobotHandler : IRequestHandler<CreateRobotCommand, RobotResponse>
    {
        private readonly IGenericRepository<RobotEntity> _robotRepo;

        public CreateRobotHandler(IGenericRepository<RobotEntity> robotRepository)
        {
            _robotRepo = robotRepository;
        }
        public async Task<RobotResponse> Handle(CreateRobotCommand request, CancellationToken cancellationToken)
        {
            var robotEntity = RobotMapper.Mapper.Map<RobotEntity>(request);
            if (robotEntity is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newRobot = await _robotRepo.AddAsync(robotEntity);
            var robotResponse = RobotMapper.Mapper.Map<RobotResponse>(newRobot);
            return robotResponse;
        }
    }
}
