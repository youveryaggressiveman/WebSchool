using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace WebSchool.Entity
{
    public partial class Country
    {
        public Country()
        {
            Cities = new HashSet<City>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<City> Cities { get; set; }
    }
}
