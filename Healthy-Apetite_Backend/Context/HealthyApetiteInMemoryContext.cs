using System.Reflection.Emit;

namespace Healthy_Apetite_Backend.Context
{
    public class HealthyApetiteInMemoryContext : HealthyApetiteContext
    {
        public HealthyApetiteInMemoryContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
