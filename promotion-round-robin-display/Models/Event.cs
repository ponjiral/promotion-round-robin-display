namespace promotion_round_robin_display.Models
{
    public class Event
    {
        public int Score { get; set; }
        public List <Promotion> Promotions { get; set; }
        public Event(int score, List<Promotion> promotions)
        {
            Score = score;
            Promotions = promotions;
        }
    }
}
