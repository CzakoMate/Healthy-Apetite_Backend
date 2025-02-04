using Healthy_Apetite_Backend.Controllers.Base;
using HealthyApetite.Shared.Dtos;
using HealthyApetite.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthyApetite.Backend.Controllers
{
    public partial class PromotionController : BaseController<Promotion, PromotionDto>
    {

        [HttpGet("getNumberOfPromotions")]
        public async Task<IActionResult> GetNumberOfPromotions()
        {
            return Ok(await _promotionRepo.GetNumberOfPromotions());
        }
    }
}
