using System;
using System.Collections.Generic;

#nullable disable

namespace WebSchool.Entity
{
    public partial class Subject
    {
        public Subject()
        {
            CurrentSchedules = new HashSet<CurrentSchedule>();
            Schedules = new HashSet<Schedule>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CurrentSchedule> CurrentSchedules { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
