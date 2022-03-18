using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SchoolApp.Application.Common.Exceptions;
using SchoolApp.Application.Interfaces;
using SchoolApp.Application.Models.DaysOfWeeks.Queries.GetDayOfWeekDetails;
using SchoolApp.Domain;
using DayOfWeek = SchoolApp.Domain.DayOfWeek;

namespace SchoolApp.Application.Models.DaysOfWeeks.Queries.GetDayOfWeek
{
    public class GetDayOfWeekQueryHandler : IRequestHandler<GetDayOfWeekQuery, IEnumerable<DayOfWeekDetailsVm>>
    {
        private readonly IMapper _mapper;
        private readonly ISchoolDbContext _schoolDb;

        public GetDayOfWeekQueryHandler(IMapper mapper, ISchoolDbContext schoolDb) =>
            (_mapper, _schoolDb) = (mapper, schoolDb);

        public async Task<IEnumerable<DayOfWeekDetailsVm>> Handle(GetDayOfWeekQuery request, CancellationToken cancellationToken)
        {
            var entities = await _schoolDb.DayOfWeeks.ProjectTo<DayOfWeekDetailsVm>(_mapper.ConfigurationProvider).ToListAsync();

            if (entities == null)
            {
                throw new NotFoundException(nameof(DayOfWeek), entities);
            }

            return entities;
        }
    }
}
