using NUnit.Framework;
using Pexeso.PexesoCore.Entity;
using Pexeso.PexesoCore.Service;

namespace PexesoTests
{
    public class TimeTests
    {
        private ITimeService ItimeService()
        {
            var scoreService = new TimeServiceFile();
            scoreService.ClearTime();
            return scoreService;
        }

        [Test]
        public void PositiveAddTime1()
        {
            var timeService = ItimeService();
            timeService.AddScore(new Time { Player = "Janko", TimeInSeconds = 120 });
            var scores = timeService.GetTopTime();
            Assert.AreEqual(1, scores.Count);
            Assert.AreEqual("Janko", scores[0].Player);
            Assert.AreEqual(120, scores[0].TimeInSeconds);
        }

        [Test]
        public void PositiveAddTime2()
        {
            var timeService = ItimeService();
            timeService.AddScore(new Time { Player = "Janko", TimeInSeconds = 120 });
            timeService.AddScore(new Time { Player = "Zuzka", TimeInSeconds = 200 });
            timeService.AddScore(new Time { Player = "Juraj", TimeInSeconds = 500 });
            var scores = timeService.GetTopTime();
            Assert.AreEqual(3, scores.Count);
            Check("Janko", 120, scores[0].Player, scores[0].TimeInSeconds);
            Check("Zuzka", 200, scores[1].Player, scores[1].TimeInSeconds);
            Check("Juraj", 500, scores[2].Player, scores[2].TimeInSeconds);
        }

        [Test]
        public void NegativeAddTime1()
        {
            var timeService = ItimeService();
            timeService.AddScore(new Time { Player = "Janko", TimeInSeconds = 120 });
            timeService.AddScore(new Time { Player = "Zuzka", TimeInSeconds = 200 });
            timeService.AddScore(new Time { Player = "Juraj", TimeInSeconds = 500 });
            var scores = timeService.GetTopTime();
            Assert.AreEqual(5, scores.Count);    //!!!!!!!!NEG
            Check("Juraj", 500, scores[0].Player, scores[0].TimeInSeconds);
            Check("Kubo", 420, scores[1].Player, scores[1].TimeInSeconds);
            Check("Martin", 301, scores[2].Player, scores[2].TimeInSeconds);
        }


        [Test]
        public void NegativeAddTime2()
        {
            var timeService = ItimeService();
            timeService.AddScore(new Time { Player = "Janko", TimeInSeconds = 120 });
            timeService.AddScore(new Time { Player = "Zuzka", TimeInSeconds = 200 });
            timeService.AddScore(new Time { Player = "Juraj", TimeInSeconds = 500 });
            timeService.AddScore(new Time { Player = "Martin", TimeInSeconds = 301 });
            timeService.AddScore(new Time { Player = "Tomas", TimeInSeconds = 100 });
            timeService.AddScore(new Time { Player = "Kubo", TimeInSeconds = 420 });
            var scores = timeService.GetTopTime();
            Assert.AreEqual(3, scores.Count);
            Check("Juraj", 500, scores[0].Player, scores[0].TimeInSeconds);
            Check("Kubo", 420, scores[1].Player, scores[1].TimeInSeconds);
            Check("Martin", 301, scores[2].Player, scores[2].TimeInSeconds);
            Check("Zuzka", 200, scores[3].Player, scores[3].TimeInSeconds);        //!!!!!!!!NEG
            Check("Janko", 120, scores[4].Player, scores[4].TimeInSeconds);        //!!!!!!!!NEG
            Check("Tomas", 100, scores[5].Player, scores[5].TimeInSeconds);        //!!!!!!!!NEG
        }

        private void Check(string playerToCheck, int timeInSecondsTocheck, string player, int timeInSeconds)
        {
            Assert.AreEqual(playerToCheck, player);
            Assert.AreEqual(timeInSecondsTocheck, timeInSeconds);
        }
    }
}