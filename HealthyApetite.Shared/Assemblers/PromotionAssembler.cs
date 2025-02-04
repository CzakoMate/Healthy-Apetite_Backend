using HealthyApetite.Shared.Models;
using HealthyApetite.Shared.Dtos;
using HealthyApetite.Shared.Extensions;

namespace HealthyApetite.Shared.Assemblers
{
    public class PromotionAssembler : Assambler<Promotion, PromotionDto>
    {
        public override PromotionDto ToDto(Promotion domainEntity)
        {
            return domainEntity.ToPromotionDto();
        }

        public override Promotion ToModel(PromotionDto dto)
        {
            return dto.ToPromotion();
        }
    }
}
