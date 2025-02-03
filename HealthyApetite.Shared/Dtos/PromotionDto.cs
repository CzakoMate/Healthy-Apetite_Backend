using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyApetite.Shared.Dtos
{
    public class PromotionDto
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double DiscountRate { get; set; }

        public PromotionDto(Guid id, DateTime startdate, DateTime endDate, double discountRate)
        {
            Id = id;
            StartDate = startdate;
            EndDate = endDate;
            DiscountRate = discountRate;
        }
        public PromotionDto()
        {
            Id=Guid.NewGuid();
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
            DiscountRate = 0;
        }

    }
}
