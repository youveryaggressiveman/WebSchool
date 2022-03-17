using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchoolApp.Application.Models.DaysOfWeeks.Queries.GetDayOfWeek;
using SchoolApp.Application.Models.DaysOfWeeks.Queries.GetDayOfWeekDetails;

namespace SchoolApp.Api.Controllers
{
    public class DayOfWeekController : BaseController
    {
        private readonly IMapper _mapper;

        public DayOfWeekController(IMapper mapper) => _mapper = mapper;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DayOfWeekDetailsVm>>> GetAll()
        {
            var query = new GetDayOfWeekQuery()
            {

            };

            var vm = await Mediator.Send(query);

            return Ok(vm);
        }
    }
}
