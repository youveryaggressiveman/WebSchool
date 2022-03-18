using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SchoolApp.Application.Common.Exceptions;
using SchoolApp.Application.Interfaces;
using SchoolApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SchoolApp.Application.Models.Cities.Queries.GetCityDetails
{
    public class GetCityDetailsCommandHandler : IRequestHandler<GetCityDetailsCommand, ICollection<CityDetailsVm>>
    {
        private readonly IMapper _mapper;
        private readonly ISchoolDbContext _dbContext;

        public GetCityDetailsCommandHandler(IMapper mapper, ISchoolDbContext dbContext) => (_mapper, _dbContext) = (mapper, dbContext);

        public async Task<ICollection<CityDetailsVm>> Handle(GetCityDetailsCommand request, CancellationToken cancellationToken)
        {
            List<CityDetailsVm> cities = new();
            var entities = await _dbContext.Countries.FirstOrDefaultAsync(country => country.ID == request.ID);

            foreach (var item in entities.Cities)
            {
                cities.Add(_mapper.Map<CityDetailsVm>(item));
            }


            if (entities == null)
            {
                throw new NotFoundException(nameof(City), request.ID);
            }

            return cities;
        }
    }
}
