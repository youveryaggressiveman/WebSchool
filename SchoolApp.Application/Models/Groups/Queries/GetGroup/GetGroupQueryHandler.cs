using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SchoolApp.Application.Common.Exceptions;
using SchoolApp.Application.Interfaces;
using SchoolApp.Application.Models.Groups.Queries.GetUserDetails;
using SchoolApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SchoolApp.Application.Models.Groups.Queries.GetGroup
{
    public class GetGroupQueryHandler : IRequestHandler<GetGroupQuery, IEnumerable<GroupDetailsVm>>
    {
        private readonly IMapper _mapper;
        private readonly ISchoolDbContext _dbContext;

        public GetGroupQueryHandler(IMapper mapper, ISchoolDbContext dbContext) => (_mapper, _dbContext) = (mapper, dbContext);

        public async Task<IEnumerable<GroupDetailsVm>> Handle(GetGroupQuery request, CancellationToken cancellationToken)
        {
            var entities = await _dbContext.Groups.ProjectTo<GroupDetailsVm>(_mapper.ConfigurationProvider).ToListAsync();

            if (entities == null)
            {
                throw new NotFoundException(nameof(Group), entities);
            }

            return entities;
        }
    }
}
