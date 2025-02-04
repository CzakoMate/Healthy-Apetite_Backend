using Healthy_Apetite_Backend.Repos;
using HealthyApetite.Shared.Models;
using HealthyApetite.Shared.Responses;
using Microsoft.AspNetCore.Mvc;
using HealthyApetite.Shared.Dtos;
using HealthyApetite.Shared.Assemblers;
using Healthy_Apetite_Backend.Controllers.Base;
namespace Healthy_Apetite_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public partial class PromotionController: BaseController<Promotion, PromotionDto>
    {
        private IPromotionRepo _promotionRepo;
        public PromotionController(PromotionAssembler? assambler, IPromotionRepo? repo) : base(assambler, repo)
        {
            _promotionRepo = repo ?? throw new ArgumentNullException(nameof(repo));
        }
    }
}
