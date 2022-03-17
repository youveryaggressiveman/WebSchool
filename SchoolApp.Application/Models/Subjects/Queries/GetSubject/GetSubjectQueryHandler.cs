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
using SchoolApp.Application.Models.Subjects.Queries.GetSubjectDetails;
using SchoolApp.Domain;

namespace SchoolApp.Application.Models.Subjects.Queries.GetSubject
{
    public class GetSubjectQueryHandler : IRequestHandler<GetSubjectQuery, IEnumerable<SubjectDetailsVm>>
    {
        private readonly IMapper _mapper;
        private readonly ISchoolDbContext _schoolDb;

        public GetSubjectQueryHandler(IMapper mapper, ISchoolDbContext schoolDb) =>
            (_mapper, _schoolDb) = (mapper, schoolDb);

        public async Task<IEnumerable<SubjectDetailsVm>> Handle(GetSubjectQuery request, CancellationToken cancellationToken)
        {
            var entities = await _schoolDb.Subjects.ProjectTo<SubjectDetailsVm>(_mapper.ConfigurationProvider)
                .ToListAsync();

            if (entities == null)
            {
                throw new NotFoundException(nameof(Subject), entities);
            }

            return entities;
        }
    }
}
