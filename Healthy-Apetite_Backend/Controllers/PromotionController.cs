using Healthy_Apetite_Backend.Repos;
using HealthyApetite.Shared.Models;
using HealthyApetite.Shared.Responses;
using Microsoft.AspNetCore.Mvc;
using HealthyApetite.Shared.Dtos;
using HealthyApetite.Shared.Extensions;
namespace Healthy_Apetite_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PromotionController: ControllerBase
    {
        private IPromotionRepo _promotionRepo;
        public PromotionController(IPromotionRepo promotionRepo)
        {
            _promotionRepo = promotionRepo;
        }
        [HttpGet]
        public async Task<IActionResult> SelectAllPromotion()
        {
            List<Promotion> promotions = new();
            if (promotions is not null)
            {
                promotions = await _promotionRepo.GetAll();
                return Ok(promotions);
            }
            return BadRequest("Az adatok elérése nem sikerült");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(Guid id)
        {
            Promotion? promotion = new();
            if (promotion is not null)
            {
                promotion = await _promotionRepo.GetBy(id);
                if (promotion is not null)
                    return Ok(promotion.ToPromotionDto());
            }
            return BadRequest("Az akció adat elérése nem sikerült.");
        }
        [HttpPut]
        public async Task<ActionResult> UpdatePromotion(PromotionDto entity)
        {
            ControllerResponse response = new();
            if (_promotionRepo is not null)
            { 
                response = await _promotionRepo.UpdatePromotion(entity.ToPromotion());
                if (response.HasError)
                {
                    return BadRequest(response);
                }
                else
                {
                    return Ok(response);
                }
            }
            response.ClearAndAddError("Az adatok firssítése nem lehetséges!");
            return BadRequest(response);
        }
    }
}
