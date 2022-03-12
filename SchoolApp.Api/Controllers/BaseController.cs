﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Claims;

namespace SchoolApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public abstract class BaseController : ControllerBase
    {
        private IMediator _mediatr;

        protected IMediator Mediator =>
            _mediatr ??= HttpContext.RequestServices.GetService<IMediator>();

        internal Guid UserID => !User.Identity.IsAuthenticated ? Guid.Empty : Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
    }
}
