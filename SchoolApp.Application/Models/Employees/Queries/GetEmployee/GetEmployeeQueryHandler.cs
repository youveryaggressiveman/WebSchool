using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SchoolApp.Application.Common.Exceptions;
using SchoolApp.Application.Interfaces;
using SchoolApp.Application.Models.Employees.Queries.GetEmployeeDetails;
using SchoolApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SchoolApp.Application.Models.Employees.Queries.GetEmployee
{
    public class GetEmployeeQueryHandler : IRequestHandler<GetEmployeeQuery, IEnumerable<EmployeeDetailsVm>>
    {
        private readonly IMapper _mapper;
        private readonly ISchoolDbContext _schoolDb;

        public GetEmployeeQueryHandler(IMapper mapper, ISchoolDbContext schoolDb) => (_mapper, _schoolDb) = (mapper, schoolDb);

        public async Task<IEnumerable<EmployeeDetailsVm>> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
             var entities = await _schoolDb.Employees.ProjectTo<EmployeeDetailsVm>(_mapper.ConfigurationProvider).ToListAsync();

            if (entities == null)
            {
                throw new NotFoundException(nameof(Employee), entities);
            }

            return entities;
        }
    }
}
