
using Healthy_Apetite_Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Healthy_Apetite_Backend.Context
{
    public class HealthyApetiteContext : DbContext
    {
        private DbSet<Promotion> _promotions;
        public HealthyApetiteContext(DbContextOptions options) : base(options)
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
