using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchoolApp.Application.Models.Schedules.Queries.GetScheduleDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Api.Controllers
{
    public class ScheduleController : BaseController
    {
        private readonly IMapper _mapper;

        public ScheduleController(IMapper mapper) => _mapper = mapper;

        [HttpGet]
        [Route("scheduleID")]
        public async Task<ActionResult<IEnumerable<ScheduleDetailsVm>>> GetScheduleByDayID(int dayID)
        {
            var query = new GetScheduleDetailsQuery()
            {
                ID = dayID
            };

            var vs = await Mediator.Send(query);

            return Ok(vs);
        }
    }
}
