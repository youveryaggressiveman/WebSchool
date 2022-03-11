using MediatR;
using SchoolApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Application.Models.Users.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<Guid>
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Code { get; set; }

        public Address Address { get; set; }
        public Passport Passport { get; set; }
    }
}
