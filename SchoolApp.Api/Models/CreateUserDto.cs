using AutoMapper;
using SchoolApp.Application.Common.Mappings;
using SchoolApp.Application.Models.Users.Commands.CreateUser;
using SchoolApp.Application.Models.Users.Queries.GetUserDetails;
using SchoolApp.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Api.Models
{
    public class CreateUserDto : IMapWith<CreateUserCommand>
    {
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string SecondName { get; set; }
        public string LastName { get; set; }

        public Address Address { get; set; }
        public Passport Passport { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateUserDto, CreateUserCommand>()
                .ForMember(userCommand => userCommand.Password,
                opt => opt.MapFrom(userDto => userDto.Password))
                .ForMember(userCommand => userCommand.Email,
                opt => opt.MapFrom(userDto => userDto.Email))
                .ForMember(userCommand => userCommand.Code,
                opt => opt.MapFrom(userDto => userDto.Code))
                .ForMember(userCommand => userCommand.FirstName,
                opt => opt.MapFrom(userDto => userDto.FirstName))
                .ForMember(userCommand => userCommand.SecondName,
                opt => opt.MapFrom(userDto => userDto.SecondName))
                .ForMember(userCommand => userCommand.LastName,
                opt => opt.MapFrom(userDto => userDto.LastName))
                .ForMember(userCommand => userCommand.Address,
                opt => opt.MapFrom(userDto => userDto.Address))
                .ForMember(userCommand => userCommand.Passport,
                opt => opt.MapFrom(userDto => userDto.Passport));
        }
    }
}
