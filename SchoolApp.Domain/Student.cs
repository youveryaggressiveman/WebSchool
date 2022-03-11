using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Domain
{
    public class Student
    {
        public Guid NumberStudentTicket { get; set; }

        public Guid UserID { get; set; }
        public int GroupID { get; set; }

        public User User { get; set; }
        public Group Group { get; set; }
    }
}
