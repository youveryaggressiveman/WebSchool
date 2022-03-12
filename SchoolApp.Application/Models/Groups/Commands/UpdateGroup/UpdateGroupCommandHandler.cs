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

namespace SchoolApp.Application.Models.Groups.Commands.UpdateGroup
{
    public class UpdateGroupCommandHandler : IRequestHandler<UpdateGroupCommand>
    {
        private readonly ISchoolDbContext _schoolDb;

        public UpdateGroupCommandHandler(ISchoolDbContext schoolDb) => _schoolDb = schoolDb;

        public async Task<Unit> Handle(UpdateGroupCommand request, CancellationToken cancellationToken)
        {
            var entity = await _schoolDb.Groups.FirstOrDefaultAsync(group => group.ID == request.ID);

            if (entity == null || entity.ID != request.ID)
            {
                throw new NotFoundException(nameof(Group), request.ID);
            }

            entity.CuratorID = request.CuratorID;
            entity.Name = request.Name;

            await _schoolDb.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
