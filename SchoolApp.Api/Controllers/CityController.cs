using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchoolApp.Application.Models.Cities.Queries.GetCityDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Api.Controllers
{
    public class CityController : BaseController
    {
        private readonly IMapper _mapper;

        public CityController(IMapper mapper) => _mapper = mapper;

        [HttpGet]
        [Route("countryID")]
        public async Task<ActionResult<IEnumerable<CityDetailsVm>>> GetCityByCountry(int countryID)
        {
            var query = new GetCityDetailsCommand()
            {
                ID = countryID
            };

            var vm = await Mediator.Send(query);

            return Ok(vm);
        }
    }
}
