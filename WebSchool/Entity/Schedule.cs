using System;
using System.Collections.Generic;

#nullable disable

namespace WebSchool.Entity
{
    public partial class Schedule
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int DayOfWeekId { get; set; }
        public int EmployeeId { get; set; }
        public int TimeSubjectId { get; set; }
        public int SubjectId { get; set; }

        public virtual DayOfWeek DayOfWeek { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Group Group { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual TimeSubject TimeSubject { get; set; }
    }
}
