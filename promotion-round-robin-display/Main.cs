using promotion_round_robin_display.Mocks;
using promotion_round_robin_display.Models;

class Program
{
    public static EventMock MockData { get; private set; } = default!;

    static void Main()
    {
        Console.WriteLine("Hello welcom");
        List<Event> data = EventMock.GetEvents();

        int promotionIndex = EventMock.GetEventsMaxPromotionIndex();
        for (int i = 0; i < promotionIndex; i++)
        {
            var promotionIds = data
                .Where(item => item.Promotions.Count > i)
                .Select(item => item.Promotions[i].Id);

            Console.WriteLine("Round "+ i);

            foreach (var id in promotionIds)
            {
                Console.Write(id);
            }
            Console.WriteLine("");
        }
    }
}