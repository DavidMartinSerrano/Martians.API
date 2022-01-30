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
    public class UpdateRobotHandler : IRequestHandler<UpdateRobotCommand, RobotResponse>
    {
        private readonly IRobotRepository _robotRepo;

        public UpdateRobotHandler(IRobotRepository robotRepository)
        {
            _robotRepo = robotRepository;
        }
        public async Task<RobotResponse> Handle(UpdateRobotCommand request, CancellationToken cancellationToken)
        {
          
                var robotEntity = RobotMapper.Mapper.Map<RobotEntity>(request);
                if (robotEntity is null)
                {
                    throw new ApplicationException("Issue with mapper");
                }
                var updatedRobot = await _robotRepo.UpdateAsync(robotEntity);
                var robotResponse = RobotMapper.Mapper.Map<RobotResponse>(updatedRobot);
                return robotResponse;
        
        }
    }
}
