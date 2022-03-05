using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace WebSchool.Entity
{
    public partial class City
    {
        public City()
        {
            Addresses = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
        [JsonIgnore]
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
