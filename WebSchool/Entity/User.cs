﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace WebSchool.Entity
{
    public partial class User
    {
        public User()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Uuid { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int AddressId { get; set; }
        public int PassportId { get; set; }
        public int RoleId { get; set; }
        public string Code { get; set; }

        public virtual Address Address { get; set; }
        public virtual Passport Passport { get; set; }
        public virtual Role Role { get; set; }
        [JsonIgnore]
        public virtual ICollection<Student> Students { get; set; }
    }
}
