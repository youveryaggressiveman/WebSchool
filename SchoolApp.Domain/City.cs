using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Domain
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CountryID { get; set; }

        public virtual Country Country { get; set; }
    }
}
