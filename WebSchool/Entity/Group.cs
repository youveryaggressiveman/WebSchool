using System;
using System.Collections.Generic;

#nullable disable

namespace WebSchool.Entity
{
    public partial class Group
    {
        public Group()
        {
            CurrentSchedules = new HashSet<CurrentSchedule>();
            Schedules = new HashSet<Schedule>();
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CuratorId { get; set; }

        public virtual Employee Curator { get; set; }
        public virtual ICollection<CurrentSchedule> CurrentSchedules { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
