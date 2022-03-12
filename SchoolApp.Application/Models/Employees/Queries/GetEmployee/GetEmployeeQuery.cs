using MediatR;
using SchoolApp.Application.Models.Employees.Queries.GetEmployeeDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Application.Models.Employees.Queries.GetEmployee
{
    public class GetEmployeeQuery : IRequest<IEnumerable<EmployeeDetailsVm>>
    {
    }
}
