using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SchoolApp.Application.Common.Exceptions;
using SchoolApp.Application.Interfaces;
using SchoolApp.Application.Models.Countries.Queries.GetCountryDetails;
using SchoolApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SchoolApp.Application.Models.Countries.Queries.GetCountry
{
    public class GetCountryQueryHandler : IRequestHandler<GetCountryQuery, IEnumerable<CountryDetailsVm>>
    {
        private readonly IMapper _mapper;
        private readonly ISchoolDbContext _dbContext;

        public GetCountryQueryHandler(IMapper mapper, ISchoolDbContext dbContext) => (_mapper, _dbContext) = (mapper, dbContext);

        public async Task<IEnumerable<CountryDetailsVm>> Handle(GetCountryQuery request, CancellationToken cancellationToken)
        {
            var entities = await _dbContext.Countries.ProjectTo<CountryDetailsVm>(_mapper.ConfigurationProvider).ToListAsync();

            if (entities == null)
            {
                throw new NotFoundException(nameof(Country), null);
            }

            return entities;
        }
    }
}
