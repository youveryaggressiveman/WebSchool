using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchoolApp.Api.Models;
using SchoolApp.Application.Models.Users.Commands.CreateUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Api.Controllers
{
    public class UserController : BaseController
    {
        private readonly IMapper _mapper;

        public UserController(IMapper mapper) => _mapper = mapper;

        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateUserDto user)
        {
            var command = _mapper.Map<CreateUserCommand>(user);

            var userID = await Mediator.Send(command);

            return Ok(userID);
        }
    }
}
