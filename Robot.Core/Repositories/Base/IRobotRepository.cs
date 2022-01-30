using Robot.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Core.Repositories.Base
{
    public interface IRobotRepository: IGenericRepository<RobotEntity>
    {
        Task<IReadOnlyList<RobotEntity>> GetAllAsync();
}
}
