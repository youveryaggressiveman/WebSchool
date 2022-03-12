using MediatR;
using SchoolApp.Application.Interfaces;
using SchoolApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SchoolApp.Application.Models.Students.Commands.CreateStudent
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, Guid>
    {
        private readonly ISchoolDbContext _dbContext;

        public CreateStudentCommandHandler(ISchoolDbContext dbContext) => _dbContext = dbContext;

        public async Task<Guid> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var user = new User()
            {
                ID = Guid.NewGuid(),
                Password = Encryption.Encrypt.HashPassword(request.User.Password),
                Email = request.User.Email,
                FirstName = request.User.FirstName,
                SecondName = request.User.SecondName,
                LastName = request.User.LastName,
                Code = request.User.Code,
                Address = request.User.Address,
                Passport = request.User.Passport,
                RoleID = 3
            };

            await _dbContext.Users.AddAsync(user, cancellationToken);

            Student newStudent = new Student()
            {
                NumberStudentTicket = Guid.NewGuid(),
                GroupID = request.GroupID,
                UserID = user.ID
            };

            await _dbContext.Students.AddAsync(newStudent, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return newStudent.NumberStudentTicket;
        }
    }
}
