using Microsoft.EntityFrameworkCore;
using Healthy_Apetite_Backend.Context;
using Healthy_Apetite_Backend.Repos;

namespace Healthy_Apetite_Backend.Extensions
{
    public static class BackendExtension
    {
        public static void AddBackend(this IServiceCollection services)
        {
            services.ConfigureCors();
            services.ConfigureInMemoryContext();
        }

        private static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(option =>
                 option.AddPolicy(name: "HealthyApetiteCors",
                     policy =>
                     {
                         policy.WithOrigins("https://0.0.0.0:7020/")
                         .AllowAnyHeader()
                         .AllowAnyMethod();
                     }
                 )
            );
        }


        private static void ConfigureInMemoryContext(this IServiceCollection services)
        {

            string dbNameHealthyApetiteContext = "HealthyApetite" + Guid.NewGuid();
            services.AddDbContext<HealthyApetiteContext>
            (
                 options => options.UseInMemoryDatabase(databaseName: dbNameHealthyApetiteContext),
                 ServiceLifetime.Scoped,
                 ServiceLifetime.Scoped
            );

            string dbNameInMemoryContext = "HealthyApetite" + Guid.NewGuid();
            services.AddDbContext<HealthyApetiteInMemoryContext>
            (
                 options => options.UseInMemoryDatabase(databaseName: dbNameInMemoryContext),
                 ServiceLifetime.Scoped,
                 ServiceLifetime.Scoped
            );
        }
        public static void ConfigureRepos(this IServiceCollection services)
        {
            services.AddScoped<IPromotionRepo, PromotionRepo>();

        }
    }
}
