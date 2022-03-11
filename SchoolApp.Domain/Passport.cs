using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Domain
{
    public class Passport
    {
        public int ID { get; set; }
        public string PassportName { get; set;}
        public string PassportNumber { get; set; }
        public DateTime DateBirth { get; set; }
    }
}
