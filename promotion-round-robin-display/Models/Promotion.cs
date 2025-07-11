namespace promotion_round_robin_display.Models
{
    public class Promotion
    {
        public string Id { get; set; }
        public DateTime StartDate { get; set; }
        public Promotion(string id, DateTime startDate)
        {
            Id = id;
            StartDate = startDate;
        }
    }
}
