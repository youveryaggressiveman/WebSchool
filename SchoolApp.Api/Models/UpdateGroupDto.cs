using AutoMapper;
using SchoolApp.Application.Common.Mappings;
using SchoolApp.Application.Models.Groups.Commands.UpdateGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Api.Models
{
    public class UpdateGroupDto : IMapWith<UpdateGroupCommand>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Guid CuratorID { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateGroupDto, UpdateGroupCommand>()
                .ForMember(groupDto => groupDto.ID,
                    opt => opt.MapFrom(group => group.ID))
                .ForMember(groupDto => groupDto.CuratorID,
                    opt => opt.MapFrom(group => group.CuratorID))
                .ForMember(groupDto => groupDto.Name,
                    opt => opt.MapFrom(group => group.Name));
        }
    }
}
