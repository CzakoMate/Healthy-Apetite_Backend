using HealthyApetite.Shared.Models;
using HealthyApetite.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyApetite.Shared.Extensions
{
    public static class PromotionExtension
    {
        public static PromotionDto ToPromotionDto(this Promotion promotion)
        {
            return new PromotionDto
            {
                Id = promotion.Id,
                StartDate= promotion.StartDate,
                EndDate = promotion.EndDate,
                DiscountRate= promotion.DiscountRate,
            };
        }
        public static Promotion ToPromotion(this PromotionDto promotionDto)
        {
            return new Promotion
            {
                Id = promotionDto.Id,
                StartDate = promotionDto.StartDate,
                EndDate = promotionDto.EndDate,
                DiscountRate = promotionDto.DiscountRate,
            };
        }
    }
}
