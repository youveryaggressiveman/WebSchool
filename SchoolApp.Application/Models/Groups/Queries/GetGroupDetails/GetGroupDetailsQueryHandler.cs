using AutoMapper;
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

namespace SchoolApp.Application.Models.Groups.Queries.GetGroupDetails
{
    public class GetGroupDetailsQueryHandler : IRequestHandler<GetGroupDetailsQuery, GroupDetailsVm>
    {
        private readonly IMapper _mapper;
        private readonly ISchoolDbContext _dbContext;

        public GetGroupDetailsQueryHandler(IMapper mapper, ISchoolDbContext dbContext) => (_mapper, _dbContext) = (mapper, dbContext);

        public async Task<GroupDetailsVm> Handle(GetGroupDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Groups.FirstOrDefaultAsync(group => group.ID == request.ID);

            if (entity == null || entity.ID != request.ID)
            {
                throw new NotFoundException(nameof(Group), request.ID);
            }

            return _mapper.Map<GroupDetailsVm>(entity);
        }
    }
}
