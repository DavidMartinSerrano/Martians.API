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
            CreateMap<RobotResponse, Robot.Core.Entities.RobotEntity>().ReverseMap();
            CreateMap<Robot.Core.Entities.RobotEntity, CreateRobotCommand>().ReverseMap();
        }
    }
}
