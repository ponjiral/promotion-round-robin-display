using promotion_round_robin_display.Mocks;
using promotion_round_robin_display.Models;

public class Program
{
    public static EventMock MockData { get; private set; } = default!;

    public static void Main(string[] args)
    {
        Console.WriteLine("Main");
        List<Event> mockData = EventMock.GetEvents();
        RunLogic(mockData, EventMock.GetEventsMaxPromotionIndex(mockData));
    }

    public static void RunLogic(List<Event> data, int promotionIndex)
    {
        for (int i = 0; i < promotionIndex; i++)
        {
            var promotionIds = data
                .Where(item => item.Promotions.Count > i)
                .Select(item => item.Promotions[i].Id);

            Console.WriteLine("Round " + i);

            foreach (var id in promotionIds)
            {
                Console.Write(id + " ");
            }
            Console.WriteLine();
        }
    }
}