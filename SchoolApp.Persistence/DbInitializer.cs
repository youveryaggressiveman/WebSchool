using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Persistence
{
    public class DbInitializer
    {
        public static void Initializer(SchoolDbContext context) => context.Database.EnsureCreated();
    }
}
