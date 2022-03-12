using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolApp.Api.Models;
using SchoolApp.Application.Models.Students.Commands.CreateStudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Api.Controllers
{
    
    public class StudentController : BaseController
    {
        private readonly IMapper _mapper;

        public StudentController(IMapper mapper) => _mapper = mapper;

        [HttpPost]

        public async Task<ActionResult<Guid>> Create([FromBody] CreateStudentDto student)
        {
            var command = _mapper.Map<CreateStudentCommand>(student);

            var studentID = await Mediator.Send(command);

            return Ok(studentID);
        }
    }
}
