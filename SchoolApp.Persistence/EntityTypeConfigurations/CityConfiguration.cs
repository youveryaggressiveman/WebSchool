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
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(city => city.ID);
            builder.HasIndex(city => city.ID).IsUnique();

            builder.Property(city => city.Name).HasMaxLength(50).IsRequired();
            builder.HasOne(city => city.Country).WithMany().IsRequired();
        }
    }
}
