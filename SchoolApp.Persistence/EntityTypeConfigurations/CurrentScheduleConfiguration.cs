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
    public class CurrentScheduleConfiguration : IEntityTypeConfiguration<CurrentSchedule>
    {
        public void Configure(EntityTypeBuilder<CurrentSchedule> builder)
        {
            builder.HasKey(currentSchedule => currentSchedule.ID);
            builder.HasIndex(currentSchedule => currentSchedule.ID).IsUnique();
            builder.HasOne(currentSchedule => currentSchedule.Group).WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(currentSchedule => currentSchedule.Subject).WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(currentSchedule => currentSchedule.TimeSubject).WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(currentSchedule => currentSchedule.DayOfWeek).WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(currentSchedule => currentSchedule.Employee).WithMany().OnDelete(DeleteBehavior.NoAction);
        }
    }
}
