using AutoMapper;
using SchoolApp.Application.Common.Mappings;
using SchoolApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Application.Models.Employees.Queries.GetEmployeeDetails
{
    public class EmployeeDetailsVm : IMapWith<Employee>
    {
        public Guid ID { get; set; }
        public int PostID { get; set; }
        public Guid UserID { get; set; }

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Employee, EmployeeDetailsVm>()
                .ForMember(employee => employee.ID,
                    opt => opt.MapFrom(employeeVm => employeeVm.ID))
                .ForMember(employee => employee.PostID,
                    opt => opt.MapFrom(employeeVm => employeeVm.PostID))
                .ForMember(employee => employee.FirstName,
                    opt => opt.MapFrom(employeeVm => employeeVm.User.FirstName))
                .ForMember(employee => employee.SecondName,
                    opt => opt.MapFrom(employeeVm => employeeVm.User.SecondName))
                .ForMember(employee => employee.LastName,
                    opt => opt.MapFrom(employeeVm => employeeVm.User.LastName))
                .ForMember(employee => employee.Role,
                    opt => opt.MapFrom(employeeVm => employeeVm.User.Role.Name))
                .ForMember(employee => employee.UserID,
                    opt => opt.MapFrom(employeeVm => employeeVm.UserID));
        }
    }
}
