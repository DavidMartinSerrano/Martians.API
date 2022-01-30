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
    public class DeleteRobotsHandler : IRequestHandler<DeleteRobotsCommand, bool>
    {
        private readonly IRobotRepository _robotRepo;

        public DeleteRobotsHandler(IRobotRepository robotRepository)
        {
            _robotRepo = robotRepository;
        }
        public async Task<bool> Handle(DeleteRobotsCommand request, CancellationToken cancellationToken)
        {           

            try
            {
                await _robotRepo.DeleteAllAsync();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }
    }
}
