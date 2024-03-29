﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Domain
{
    public class Group
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Guid CuratorID { get; set; }

        public virtual Employee Curator { get; set; }
    }
}
