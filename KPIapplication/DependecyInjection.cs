using AutoMapper;
using KPIapplication.Abstraction;
using KPIapplication.MappingProfile;
using KPIapplication.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPIapplication
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();

            services.AddAutoMapper(typeof(MapProfile));

            return services;
        }
    }
}
