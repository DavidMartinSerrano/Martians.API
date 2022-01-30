using Microsoft.EntityFrameworkCore;
using Robot.Core.Entities;
using Robot.Core.Repositories.Base;
using Robot.Infrastructure.Data;
using Robot.Infrastructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Infrastructure.Repository
{
    public class RobotRepository:GenericRepository<RobotEntity>, IRobotRepository
    {
        public RobotRepository(RobotContext robotContext):base(robotContext)
        {

        }

        public async override Task<IReadOnlyList<RobotEntity>> GetAllAsync()
        {
            return await _robotContext.Set<RobotEntity>().Include(r => r.Coordinates).Include(r => r.Troubles).Include(r => r.Coordinates).ToListAsync();

        }
    }
}
