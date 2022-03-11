using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Persistence.EntityTypeConfigurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(student => student.NumberStudentTicket);
            builder.HasIndex(student => student.NumberStudentTicket).IsUnique();

            builder.HasOne(student => student.Group).WithMany().IsRequired();
            builder.HasOne(student => student.User).WithMany().IsRequired();
        }
    }
}
