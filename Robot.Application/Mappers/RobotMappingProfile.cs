using AutoMapper;
using Robot.Application.Commands;
using Robot.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Robot.Application.Mappers
{
    public class RobotMappingProfile : Profile
    {
        public RobotMappingProfile()
        {
            CreateMap<Robot.Core.Entities.RobotEntity, RobotResponse>();
            CreateMap<CreateRobotCommand, Robot.Core.Entities.RobotEntity>();
            CreateMap<Robot.Core.Entities.CoordinatesEntity, CoordinatesResponse>();
            CreateMap<Robot.Core.Entities.TroubleEntity, TroubleResponse>();

        }
    }
}
