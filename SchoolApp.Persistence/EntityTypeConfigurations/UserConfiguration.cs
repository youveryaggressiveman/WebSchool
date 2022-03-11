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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(user => user.ID);
            builder.HasIndex(user => user.ID).IsUnique();

            builder.Property(user => user.Email).HasMaxLength(50).IsRequired();
            builder.Property(user => user.Password).HasMaxLength(50).IsRequired();
            builder.Property(user => user.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(user => user.SecondName).HasMaxLength(50).IsRequired();
            builder.Property(user => user.LastName).HasMaxLength(50);
            builder.Property(user => user.Code).HasMaxLength(10);
            builder.HasOne(user => user.Role).WithMany().IsRequired();
            builder.HasOne(user => user.Passport).WithMany().IsRequired();
            builder.HasOne(user => user.Address).WithMany().IsRequired();
        }
    }
}
