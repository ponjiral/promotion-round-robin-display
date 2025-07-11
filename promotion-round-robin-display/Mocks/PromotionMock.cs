using promotion_round_robin_display.Models;

namespace promotion_round_robin_display.Mocks
{
    public class PromotionMock
    {
        public PromotionMock()
        {
        }

        public static List<Promotion> GetPromotionsA_C()
        {
            var returnData = new List<Promotion>
            {
                new Promotion("a", DateTime.Parse("2024-09-01")),  
                new Promotion("b", DateTime.Parse("2024-09-05")),
                new Promotion("c", DateTime.Parse("2024-09-10"))
            };
            return returnData.OrderBy(_ => _.StartDate).ThenBy(_ => _.Id).ToList();
        }
        public static List<Promotion> GetPromotionsD_F()
        {
            var returnData = new List<Promotion>
            {
                new Promotion("d", DateTime.Parse("2024-08-30")),
                new Promotion("e", DateTime.Parse("2024-09-04")),
                new Promotion("f", DateTime.Parse("2024-09-09")),
            };
            return returnData.OrderBy(_ => _.StartDate).ThenBy(_ => _.Id).ToList();
        }

        public static List<Promotion> GetPromotionsG_I()
        {
            var returnData = new List<Promotion>
            {
                new Promotion("g", DateTime.Parse("2024-09-02")),
                new Promotion("h", DateTime.Parse("2024-09-06")),
                new Promotion("i", DateTime.Parse("2024-09-11")),
            };
            return returnData.OrderBy(_ => _.StartDate).ThenBy(_ => _.Id).ToList();
        }
    }
}
