using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Domain
{
    public class CurrentSchedule
    {
        public int ID { get; set; }

        public int GroupID { get; set; }
        public Guid EmployeeID { get; set; }
        public int DayOfWeekID { get; set; }
        public int TimeSubjectID { get; set; }
        public int SubjectID { get; set; }

        public Group Group { get; set; }
        public Employee Employee { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSubject TimeSubject { get; set; }
        public Subject Subject { get; set; }
    }
}
