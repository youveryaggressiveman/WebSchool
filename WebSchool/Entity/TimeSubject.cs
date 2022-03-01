using System;
using System.Collections.Generic;

#nullable disable

namespace WebSchool.Entity
{
    public partial class TimeSubject
    {
        public TimeSubject()
        {
            CurrentSchedules = new HashSet<CurrentSchedule>();
            Schedules = new HashSet<Schedule>();
        }

        public int Id { get; set; }
        public TimeSpan Begin { get; set; }
        public TimeSpan End { get; set; }

        public virtual ICollection<CurrentSchedule> CurrentSchedules { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
