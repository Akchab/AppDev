using AppDev.Application.Common.Interface;
using AppDev.Infrastructure.Persistence;
using AppDev.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppDev.Infrastructure.DI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDBContext>(optionsAction: options =>
            options.UseSqlServer(configuration.GetConnectionString(name: "SummerClassDatabaseMSSQL"), b =>

            b.MigrationsAssembly(typeof(ApplicationDBContext).Assembly.FullName)),
            ServiceLifetime.Transient);

            services.AddScoped<IApplicationDBContext>(provider => provider.GetService<ApplicationDBContext>());
            services.AddTransient<IDateTime, DateTimeService>();


            return services;


            }
            
            

    }
}
