using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Domain
{
    public class User
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Code { get; set; }
        
        public int RoleID { get; set; }
        public int AddressID { get; set; }
        public int PassportID { get; set; }

        public Role Role { get; set; }
        public Address Address { get; set; }
        public Passport Passport { get; set; }
    }
}
