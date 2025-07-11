namespace promotion_round_robin_display.Models
{
    public class Event
    {
        public int Score { get; set; }
        public List <string> Promotions { get; set; }
        public Event(int score, List<string> promotions)
        {
            Score = score;
            Promotions = promotions;
        }
    }
}
