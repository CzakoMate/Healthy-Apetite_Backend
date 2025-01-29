using System.Xml.Linq;

namespace Healthy_Apetite_Backend.Datas.Entities
{
    public class Promotion
    {
        public Promotion()
        {
            Id = Guid.NewGuid();
            StartDate=DateTime.Now;
            EndDate = DateTime.Now;
            DiscountRate = 0;
        }


        public Promotion(DateTime startdate, DateTime endDate, double discountRate)
        {
            Id = Guid.NewGuid();

            StartDate = startdate;
            EndDate = endDate;
            DiscountRate = discountRate;
        }

        public Promotion(Guid id, DateTime startdate, DateTime endDate, double discountRate)
        {
            Id = id;
            StartDate = startdate;
            EndDate = endDate;
            DiscountRate = discountRate;
        }


        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double DiscountRate {  get; set; }
        public override string ToString()
        {
            return $"{StartDate} -től, {EndDate}-ig {DiscountRate}%-os akció.";
        }

    }
}
