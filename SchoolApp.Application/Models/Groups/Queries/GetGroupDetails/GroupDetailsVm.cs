using AutoMapper;
using SchoolApp.Application.Common.Mappings;
using SchoolApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Application.Models.Groups.Queries.GetUserDetails
{
    public class GroupDetailsVm : IMapWith<Group>
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Group, GroupDetailsVm>()
                .ForMember(group => group.ID,
                    opt => opt.MapFrom(groupVm => groupVm.ID))
                .ForMember(group => group.Name,
                    opt => opt.MapFrom(groupVm => groupVm.Name));
        }
    }
}
