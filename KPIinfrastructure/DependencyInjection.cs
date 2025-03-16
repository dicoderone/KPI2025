using KPIinfrastructure.Persistence;
using KPIinfrastructure.Repositories;
using KPIinfrastructure.Repositories.Implication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace KPIinfrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDatabase(configuration);

            return services;
        }

        private static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddScoped<IDocumentRepository, DocumentRepository>();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(connectionString,
                    opt => opt.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
        }

        //private static void AddIdentity(this IServiceCollection services)
        //{
        //    services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
        //        .AddEntityFrameworkStores<DataBaseContext>();

        //    services.Configure<IdentityOptions>(options =>
        //    {
        //        options.Password.RequireDigit = true;
        //        options.Password.RequireLowercase = true;
        //        options.Password.RequireNonAlphanumeric = true;
        //        options.Password.RequireUppercase = true;
        //        options.Password.RequiredLength = 6;
        //        options.Password.RequiredUniqueChars = 1;

        //        options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
        //        options.Lockout.MaxFailedAccessAttempts = 5;
        //        options.Lockout.AllowedForNewUsers = true;

        //        options.User.AllowedUserNameCharacters =
        //            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
        //        options.User.RequireUniqueEmail = true;
        //    });
        //}
    }
}
