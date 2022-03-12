using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchoolApp.Application.Models.Employees.Queries.GetEmployee;
using SchoolApp.Application.Models.Employees.Queries.GetEmployeeDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Api.Controllers
{
    public class EmployeeController : BaseController
    {
        private readonly IMapper _mapper;

        public EmployeeController(IMapper mapper) => _mapper = mapper;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeDetailsVm>>> GetAll()
        {
            var query = new GetEmployeeQuery()
            {

            };

            var vm = await Mediator.Send(query);

            return Ok(vm);
        }
    }
}
