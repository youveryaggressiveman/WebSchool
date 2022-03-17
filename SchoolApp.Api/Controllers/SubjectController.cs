using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchoolApp.Application.Models.Subjects.Queries.GetSubject;
using SchoolApp.Application.Models.Subjects.Queries.GetSubjectDetails;

namespace SchoolApp.Api.Controllers
{
    public class SubjectController : BaseController
    {
        private readonly IMapper _mapper;

        public SubjectController(IMapper mapper) => _mapper = mapper;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubjectDetailsVm>>> GetAll()
        {
            var query = new GetSubjectQuery()
            {

            };

            var vm = await Mediator.Send(query);

            return Ok(vm);
        }
    }
}
