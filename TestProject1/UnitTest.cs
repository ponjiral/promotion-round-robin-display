using promotion_round_robin_display.Mocks;
using promotion_round_robin_display.Models;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RunLogicUnitTest()
        {
            Console.WriteLine("Unit Test");

            List<Event> dataCase1 = EventMock.GetEventsforUnitTestCase3_4();
            Program.RunLogic(dataCase1, EventMock.GetEventsMaxPromotionIndex(dataCase1));
            // Result should be d l qs *\n* e k o *\n* f n p *\n* m r 
            Assert.Pass();
        }
    }
}