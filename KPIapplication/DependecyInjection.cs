using KPIapplication.MappingProfile;
using KPIapplication.Services;
using KPIapplication.Services.Implication;
using Microsoft.Extensions.DependencyInjection;

namespace KPIapplication
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.RegisterAutoMapper();
            services.AddDatabase();
            services.RegisterCashing();

            return services;
        }

        private static void AddDatabase(this IServiceCollection services)
        {
            services.AddScoped<IDocumentService, DocumentService>();
        }

        private static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(IMappingProfilesMarker));
        }

        private static void RegisterCashing(this IServiceCollection services)
        {
            services.AddMemoryCache();
        }
    }
}
