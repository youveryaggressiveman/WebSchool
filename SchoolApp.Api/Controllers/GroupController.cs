using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchoolApp.Api.Models;
using SchoolApp.Application.Models.Groups.Commands.UpdateGroup;
using SchoolApp.Application.Models.Groups.Queries.GetGroup;
using SchoolApp.Application.Models.Groups.Queries.GetGroupDetails;
using SchoolApp.Application.Models.Groups.Queries.GetUserDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Api.Controllers
{
    public class GroupController : BaseController
    {
        private readonly IMapper _mapper;

        public GroupController(IMapper mapper) => _mapper = mapper;

        [HttpPut]
        [Route("group")]
        public async Task<ActionResult> Put([FromBody] UpdateGroupDto group)
        {
            var command = _mapper.Map<UpdateGroupCommand>(group);

            await Mediator.Send(command);

            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GroupDetailsVm>>> GetAll()
        {
            var query = new GetGroupQuery()
            {

            };

            var vm = await Mediator.Send(query);

            return Ok(vm);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GroupDetailsVm>> Get(int id)
        {
            var query = new GetGroupDetailsQuery
            {
                ID = id
            };

            var vm = await Mediator.Send(query);

            return Ok(vm);
        }
    }
}
