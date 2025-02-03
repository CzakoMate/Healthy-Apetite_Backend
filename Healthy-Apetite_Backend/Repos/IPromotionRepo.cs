using HealthyApetite.Shared.Models;
using HealthyApetite.Shared.Responses;

namespace Healthy_Apetite_Backend.Repos
{
    public interface IPromotionRepo
    {
        Task<List<Promotion>> GetAll();
        Task<Promotion> GetBy(Guid id);
        Task<ControllerResponse> UpdatePromotion(Promotion promotion);
    }
}
