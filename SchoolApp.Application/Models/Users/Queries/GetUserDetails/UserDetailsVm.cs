using AutoMapper;
using SchoolApp.Application.Common.Mappings;
using SchoolApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Application.Models.Users.Queries.GetUserDetails
{
    public class UserDetailsVm : IMapWith<User>
    {
        public Guid ID { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }

        public Address Address { get; set; }
        public Passport Passport { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<User, UserDetailsVm>()
                .ForMember(userVm => userVm.ID,
                    opt => opt.MapFrom(user => user.ID))
                .ForMember(userVm => userVm.Email,
                    opt => opt.MapFrom(user => user.Email))
                .ForMember(userVm => userVm.FirstName,
                    opt => opt.MapFrom(user => user.FirstName))
                .ForMember(userVm => userVm.SecondName,
                    opt => opt.MapFrom(user => user.SecondName))
                .ForMember(userVm => userVm.LastName,
                    opt => opt.MapFrom(user => user.LastName))
                .ForMember(userVm => userVm.Role,
                    opt => opt.MapFrom(user => user.Role.Name))
                .ForMember(userVm => userVm.Address,
                    opt => opt.MapFrom(user => user.Address))
                .ForMember(userVm => userVm.Passport,
                    opt => opt.MapFrom(user => user.Passport));
        }
    }
}
