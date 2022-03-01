using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace WebSchool.Entity
{
    public partial class Address
    {
        public Address()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string AddressNumber { get; set; }
        public string AddressName { get; set; }
        public int CityId { get; set; }

        public virtual City City { get; set; }

        [JsonIgnore]
        public virtual ICollection<User> Users { get; set; }
    }
}
