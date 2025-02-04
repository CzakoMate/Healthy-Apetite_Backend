using HealthyApetite.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Healthy_Apetite_Backend.Context
{
    public class HealthyApetiteContext : DbContext
    {
        private DbSet<Promotion> _promotions;
        public HealthyApetiteContext(DbContextOptions<HealthyApetiteContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Promotion> Promotions { get; set; }
    }
}
