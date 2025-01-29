using Healthy_Apetite_Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Healthy_Apetite_Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Promotion> promotions = new List<Promotion>
            {
                new Promotion
                {
                    StartDate =new DateTime(2025,01,19),
                    EndDate = new DateTime(2025,03,01),
                    DiscountRate=5,
                },
                new Promotion
                {
                    StartDate =new DateTime(2025,02,17),
                    EndDate = new DateTime(2025,04,01),
                    DiscountRate=5,
                },
                new Promotion
                {
                    StartDate =new DateTime(2025,03,22),
                    EndDate = new DateTime(2025,04,01),
                    DiscountRate=5,
                },
            };
            modelBuilder.Entity<Promotion>().HasData(promotions);
        }
    }
}
