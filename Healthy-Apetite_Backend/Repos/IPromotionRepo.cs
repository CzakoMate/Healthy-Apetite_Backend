using Healthy_Apetite_Backend.Repos.Base;
using HealthyApetite.Shared.Models;
using HealthyApetite.Shared.Responses;

namespace Healthy_Apetite_Backend.Repos
{
    public interface IPromotionRepo: IBaseRepo<Promotion>
    {
        Task<int>GetNumberOfPromotions();
    }
}
