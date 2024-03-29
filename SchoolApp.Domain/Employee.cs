﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Domain
{
    public class Employee
    {
        public Guid ID { get; set; }

        public Guid UserID { get; set; }
        public int PostID { get; set; }

        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
    }
}
