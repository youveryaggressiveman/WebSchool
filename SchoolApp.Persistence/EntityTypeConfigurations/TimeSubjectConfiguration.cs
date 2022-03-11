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
    public class TimeSubjectConfiguration : IEntityTypeConfiguration<TimeSubject>
    {
        public void Configure(EntityTypeBuilder<TimeSubject> builder)
        {
            builder.HasKey(timeSubject => timeSubject.ID);
            builder.HasIndex(timeSubject => timeSubject.ID).IsUnique();

            builder.Property(timeSubject => timeSubject.End).IsRequired();
            builder.Property(timeSubject => timeSubject.Begin).IsRequired();
        }
    }
}
