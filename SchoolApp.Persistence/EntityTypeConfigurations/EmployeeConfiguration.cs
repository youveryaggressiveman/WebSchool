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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(employee => employee.ID);
            builder.HasIndex(employee => employee.ID).IsUnique();

            builder.HasOne(employee => employee.Post).WithMany().IsRequired();
            builder.HasOne(employee => employee.User).WithMany().IsRequired();
        }
    }
}
