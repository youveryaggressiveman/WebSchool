﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Domain
{
    public class Address
    {
        public int ID { get; set; }
        public string AddressName { get; set;}
        public string AddressNumber { get; set; }

        public virtual ICollection<City> City { get; set;}
    }
}
