using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchoolApp.Application.Models.Countries.Queries.GetCountry;
using SchoolApp.Application.Models.Countries.Queries.GetCountryDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Api.Controllers
{
    public class CountryController : BaseController
    {
        private readonly IMapper _mapper;

        public CountryController(IMapper mapper) => _mapper = mapper;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CountryDetailsVm>>> GetAll()
        {
            var query = new GetCountryQuery()
            {

            };

            var vm = await Mediator.Send(query);

            return Ok(vm);
        }
    }
}
