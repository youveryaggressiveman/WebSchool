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
using SchoolApp.Application.Models.TimeSubjects.Queries.GetTimeSubjectDetails;
using SchoolApp.Domain;

namespace SchoolApp.Application.Models.TimeSubjects.Queries.GetTimeSubject
{
    public class GetTimeSubjectQueryHandler : IRequestHandler<GetTimeSubjectQuery, IEnumerable<TimeSubjectDetailsVm>>
    {
        private readonly IMapper _mapper;
        private readonly ISchoolDbContext _schoolDb;

        public GetTimeSubjectQueryHandler(IMapper mapper, ISchoolDbContext schoolDb) =>
            (_mapper, _schoolDb) = (mapper, schoolDb);

        public async Task<IEnumerable<TimeSubjectDetailsVm>> Handle(GetTimeSubjectQuery request, CancellationToken cancellationToken)
        {
            var entities = await _schoolDb.TimeSubjects.ProjectTo<TimeSubjectDetailsVm>(_mapper.ConfigurationProvider)
                .ToListAsync();

            if (entities == null)
            {
                throw new NotFoundException(nameof(TimeSubject), entities);
            }

            return entities;
        }
    }
}
