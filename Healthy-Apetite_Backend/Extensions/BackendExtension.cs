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
                 option.AddPolicy(name: "KretaCors",
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
            string dbNameInMemoryContext = "Kreta" + Guid.NewGuid();
            services.AddDbContext<HealthyApetiteInMemoryContext>
            (
                 options => options.UseInMemoryDatabase(databaseName: dbNameInMemoryContext),
                 ServiceLifetime.Scoped,
                 ServiceLifetime.Scoped
            );
        }
    }
}
