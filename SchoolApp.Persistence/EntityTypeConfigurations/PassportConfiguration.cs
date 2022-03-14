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
    public class PassportConfiguration : IEntityTypeConfiguration<Passport>
    {
        public void Configure(EntityTypeBuilder<Passport> builder)
        {
            builder.HasKey(passport => passport.ID);
            builder.HasIndex(passport => passport.ID).IsUnique();

            builder.Property(passport => passport.PassportSerial).HasMaxLength(20).IsRequired();
            builder.Property(passport => passport.PassportNumber).HasMaxLength(20).IsRequired();
            builder.Property(passport => passport.DateBirth).IsRequired();
        }
    }
}
