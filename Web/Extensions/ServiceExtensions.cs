using Domain.Contexts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Extensions
{
    public static class ServiceExtensions
    {
        private static IConfiguration Configuration;
        public static IServiceCollection ConfigureDbContext(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>();

            return services;
        }

        public static IServiceCollection ConfigureDbContext(this IServiceCollection services,IConfiguration configuration)
        {
            Configuration = configuration;
            services.AddDbContext<AppDbContext>();
            return services;
        }
    }
}
