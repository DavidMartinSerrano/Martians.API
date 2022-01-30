using MediatR;
using Robot.Application.Mappers;
using Robot.Application.Queries;
using Robot.Application.Responses;
using Robot.Core.Entities;
using Robot.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Robot.Application.Handler.QueryHandlers
{
    public class GetAllRobotsHandler : IRequestHandler<GetAllRobotsQuery, List<RobotResponse>>
    {
        private readonly IRobotRepository _robotRepo;

        public GetAllRobotsHandler(IRobotRepository robotRepo)
        {
            _robotRepo = robotRepo;
        }
        public async Task<List<RobotResponse>> Handle(GetAllRobotsQuery request, CancellationToken cancellationToken)
        {       
            return RobotMapper.Mapper.Map<List<RobotResponse>>(await _robotRepo.GetAllAsync());
        }
    }
}
