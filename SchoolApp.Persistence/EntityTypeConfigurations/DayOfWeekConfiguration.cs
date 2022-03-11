using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DayOfWeek = SchoolApp.Domain.DayOfWeek;

namespace SchoolApp.Persistence.EntityTypeConfigurations
{
    public class DayOfWeekConfiguration : IEntityTypeConfiguration<DayOfWeek>
    {
        public void Configure(EntityTypeBuilder<DayOfWeek> builder)
        {
            builder.HasKey(dayOfWeek => dayOfWeek.ID);
            builder.HasIndex(dayOfWeek => dayOfWeek.ID).IsUnique();

            builder.Property(dayOfWeek => dayOfWeek.Name).HasMaxLength(50).IsRequired();
        }
    }
}
