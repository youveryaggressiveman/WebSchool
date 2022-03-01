using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace WebSchool.Entity
{
    public partial class Passport
    {
        public Passport()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string PassportSerial { get; set; }
        public string PassportNumber { get; set; }
        public DateTime DateBith { get; set; }

        [JsonIgnore]
        public virtual ICollection<User> Users { get; set; }
    }
}
