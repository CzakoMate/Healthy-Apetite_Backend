using Healthy_Apetite_Backend.Datas.Entities;
using Healthy_Apetite_Backend.Datas.Responses;

namespace Healthy_Apetite_Backend.Repos
{
    public interface IPromotionRepo
    {
        Task<List<Promotion>> GetAll();
        Task<Promotion> GetBy(Guid id);
        Task<ControllerResponse> UpdatePromotion(Promotion promotion);
    }
}
