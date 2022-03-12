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
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(group => group.ID);
            builder.HasIndex(group => group.ID).IsUnique();

            builder.Property(group => group.Name).HasMaxLength(50).IsRequired();
            builder.HasOne(group => group.Curator).WithMany();
        }
    }
}
