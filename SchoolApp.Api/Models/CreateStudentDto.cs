using AutoMapper;
using SchoolApp.Application.Common.Mappings;
using SchoolApp.Application.Models.Students.Commands.CreateStudent;
using SchoolApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Api.Models
{
    public class CreateStudentDto : IMapWith<CreateStudentCommand>
    {
        public int GroupID { get; set; }
        public User User { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateStudentDto, CreateStudentCommand>()
                .ForMember(studentDto => studentDto.GroupID,
                    opt => opt.MapFrom(student => student.GroupID))
                .ForMember(studentDto => studentDto.User,
                    opt => opt.MapFrom(student => student.User));
        }
    }
}
