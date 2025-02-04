using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Healthy_Apetite_Backend.Context
{
    public class HealthyApetiteInMemoryContext : HealthyApetiteContext
    {
        public HealthyApetiteInMemoryContext(DbContextOptions<HealthyApetiteContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
