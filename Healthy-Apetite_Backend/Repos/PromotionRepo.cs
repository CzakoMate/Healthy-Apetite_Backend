using Healthy_Apetite_Backend.Context;
using HealthyApetite.Shared.Models;
using HealthyApetite.Shared.Responses;
using Microsoft.EntityFrameworkCore;

namespace Healthy_Apetite_Backend.Repos
{
    public class PromotionRepo: IPromotionRepo
    {
        public async Task<List<Promotion>> GetAll()
        {
            return await _dbContext.Promotions.ToListAsync();
        }

        public async Task<Promotion?> GetBy(Guid id)
        {
            return await _dbContext.Promotions.FirstOrDefaultAsync(s => s.Id == id);
        }

        private readonly HealthyApetiteInMemoryContext _dbContext;

        public PromotionRepo(HealthyApetiteInMemoryContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ControllerResponse> UpdatePromotion(Promotion promotion)
        {
            ControllerResponse response = new ControllerResponse();
            _dbContext.ChangeTracker.Clear();
            _dbContext.Entry(promotion).State = EntityState.Modified;
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                response.AppendNewError(e.Message);
                response.AppendNewError($"{nameof(PromotionRepo)} osztály, {nameof(UpdatePromotion)} metódusban hiba keletkezett");
                response.AppendNewError($"{promotion} frissítése nem sikerült!");
            }
            return response;
        }
    }
}
