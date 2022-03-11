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
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.HasKey(schedule => schedule.ID);
            builder.HasIndex(schedule => schedule.ID).IsUnique();

            builder.HasOne(schedule => schedule.Group).WithMany().IsRequired();
            builder.HasOne(schedule => schedule.Subject).WithMany().IsRequired();
            builder.HasOne(schedule => schedule.TimeSubject).WithMany().IsRequired();
            builder.HasOne(schedule => schedule.Employee).WithMany().IsRequired();
            builder.HasOne(schedule => schedule.DayOfWeek).WithMany().IsRequired();
        }
    }
}
