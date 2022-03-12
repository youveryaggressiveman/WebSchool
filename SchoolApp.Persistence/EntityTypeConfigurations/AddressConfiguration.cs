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
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(address => address.ID);
            builder.HasIndex(address => address.ID).IsUnique();

            builder.Property(address => address.AddressName).HasMaxLength(50).IsRequired();
            builder.Property(address => address.AddressNumber).HasMaxLength(50).IsRequired();
        }
    }
}
