using MediatR;
using SchoolApp.Application.Interfaces;
using SchoolApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SchoolApp.Application.Models.Users.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
    {
        private readonly ISchoolDbContext _dbContext;

        public CreateUserCommandHandler(ISchoolDbContext dbContext) =>
            _dbContext = dbContext;

        public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User()
            {
                ID = Guid.NewGuid(),
                Password = Encryption.Encrypt.HashPassword(request.Password),
                Email = request.Email,
                FirstName = request.FirstName,
                SecondName = request.SecondName,
                LastName = request.LastName,
                Code = request.Code,
                Address = request.Address,
                Passport = request.Passport,
                RoleID = 3
            };

            await _dbContext.Users.AddAsync(user, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return user.ID;
        }
    }
}
