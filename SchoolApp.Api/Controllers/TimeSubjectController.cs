using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchoolApp.Application.Models.TimeSubjects.Queries.GetTimeSubject;
using SchoolApp.Application.Models.TimeSubjects.Queries.GetTimeSubjectDetails;

namespace SchoolApp.Api.Controllers
{
    public class TimeSubjectController : BaseController
    {
        private readonly IMapper _mapper;

        public TimeSubjectController(IMapper mapper) => _mapper = mapper;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TimeSubjectDetailsVm>>> GetAll()
        {
            var query = new GetTimeSubjectQuery()
            {

            };

            var vm = await Mediator.Send(query);

            return Ok(vm);
        }
    }
}
