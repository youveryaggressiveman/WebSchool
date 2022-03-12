using AutoMapper;
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

namespace SchoolApp.Application.Models.Users.Queries.GetUserDetails
{
    public class GetUserDetailsQueryHandler : IRequestHandler<GetUserDetailsQuery, UserDetailsVm>
    {
        private readonly ISchoolDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetUserDetailsQueryHandler(ISchoolDbContext dbContext, IMapper mapper) => (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<UserDetailsVm> Handle(GetUserDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Users.FirstOrDefaultAsync(user => user.ID == request.ID);

            if (entity == null || entity.ID != request.ID)
            {
                throw new NotFoundException(nameof(User), request.ID);
            }

            return _mapper.Map<UserDetailsVm>(entity);
        }
    }
}
