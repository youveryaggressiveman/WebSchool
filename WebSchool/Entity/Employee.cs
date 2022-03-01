using System;
using System.Collections.Generic;

#nullable disable

namespace WebSchool.Entity
{
    public partial class Employee
    {
        public Employee()
        {
            CurrentSchedules = new HashSet<CurrentSchedule>();
            Groups = new HashSet<Group>();
            Schedules = new HashSet<Schedule>();
        }

        public int Id { get; set; }
        public int PostId { get; set; }

        public virtual Post Post { get; set; }
        public virtual ICollection<CurrentSchedule> CurrentSchedules { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
