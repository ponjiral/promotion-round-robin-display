using promotion_round_robin_display.Models;
using promotion_round_robin_display.Mocks; // Add this to access PromotionMock

namespace promotion_round_robin_display.Mocks
{
    public class EventMock
    {
        public EventMock() { }

        public static List<Event> GetEvents()
        {
            var returnData = new List<Event>
            {
                new Event(7, PromotionMock.GetPromotionsA_C()),
                new Event(6, PromotionMock.GetPromotionsD_F()),
                new Event(5, PromotionMock.GetPromotionsG_I())
            };
            return returnData.OrderByDescending(_ => _.Score).ToList();
        }

        public static int GetEventsMaxPromotionIndex(List<Event> dataList)
        {
            return dataList.Max(_ => _.Promotions.Count);
        }

        public static List<Event> GetEventsforUnitTestCase3_4()
        {
            var returnData = new List<Event>
            {
                new Event(4, PromotionMock.GetPromotionsforUnitTestCase34_1()),
                new Event(6, PromotionMock.GetPromotionsD_F()),
                new Event(4, PromotionMock.GetPromotionsforUnitTestCase34_2())
            };
            return returnData.OrderByDescending(_ => _.Score).ToList();
        }
    }
}
