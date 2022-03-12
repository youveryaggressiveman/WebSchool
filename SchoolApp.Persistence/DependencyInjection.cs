using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SchoolApp.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];

            services.AddDbContext<SchoolDbContext>(opt =>
            {
                opt.UseLazyLoadingProxies();
                opt.UseSqlServer(connectionString);
            });

            services.AddScoped<ISchoolDbContext>(provider => provider.GetService<SchoolDbContext>());

            return services;
        }
    }
}
