using Healthy_Apetite_Backend.Context;
using HealthyApetite.Shared.Models;
using HealthyApetite.Shared.Responses;
using Microsoft.EntityFrameworkCore;
using Healthy_Apetite_Backend.Repos.Base;

namespace Healthy_Apetite_Backend.Repos
{
    public class PromotionRepo<TDbContext> : BaseRepo<TDbContext, Promotion>, IPromotionRepo where TDbContext : HealthyApetiteContext
    {
        public PromotionRepo(TDbContext? dbContext) : base(dbContext)
        {
        }

        public async Task<int> GetNumberOfPromotions()
        {
            return await _dbSet.CountAsync();
        }
    }
}
