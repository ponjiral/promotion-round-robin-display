using promotion_round_robin_display.Models;
using promotion_round_robin_display.Mocks; // Add this to access PromotionMock

namespace promotion_round_robin_display.Mocks
{
    public class EventMock
    {
        public EventMock() { }

        public static List<Event> GetEvents()
        {
            return new List<Event>
            {
                new Event(7, PromotionMock.GetPromotionsA_C()),
                new Event(6, PromotionMock.GetPromotionsD_F()),
                new Event(5, PromotionMock.GetPromotionsG_I())
            };
        }
    }
}
