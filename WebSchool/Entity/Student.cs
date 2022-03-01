using System;
using System.Collections.Generic;

#nullable disable

namespace WebSchool.Entity
{
    public partial class Student
    {
        public string NumberStudentTicket { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }

        public virtual Group Group { get; set; }
        public virtual User User { get; set; }
    }
}
