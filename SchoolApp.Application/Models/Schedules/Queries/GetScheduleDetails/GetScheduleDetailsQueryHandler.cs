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

namespace SchoolApp.Application.Models.Schedules.Queries.GetScheduleDetails
{
    public class GetScheduleDetailsQueryHandler : IRequestHandler<GetScheduleDetailsQuery, IEnumerable<ScheduleDetailsVm>>
    {
        private readonly IMapper _mapper;
        private readonly ISchoolDbContext _dbContext;

        public GetScheduleDetailsQueryHandler(IMapper mapper, ISchoolDbContext dbContext) => (_mapper, _dbContext) = (mapper, dbContext);

        public async Task<IEnumerable<ScheduleDetailsVm>> Handle(GetScheduleDetailsQuery request, CancellationToken cancellationToken)
        {
            var entities = await _dbContext.Schedules.Where(schedule => schedule.DayOfWeekID == request.ID).ProjectTo<ScheduleDetailsVm>(_mapper.ConfigurationProvider).ToListAsync();

            if (entities == null)
            {
                throw new NotFoundException(nameof(Schedule), entities);
            }

            return entities;
        }
    }
}
