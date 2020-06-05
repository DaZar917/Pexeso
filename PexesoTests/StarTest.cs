using NUnit.Framework;
using Pexeso.PexesoCore.Entity;
using Pexeso.PexesoCore.Service.StarService;

namespace PexesoTests
{
    public class StarTests
    {
        private IStarService IStarService()
        {
            var starService = new StarServiceFile();
            starService.ClearStars();
            return starService;
        }

        [Test]
        public void PositiveAddStar1()
        {
            var starService = IStarService();
            starService.AddStar(new Star { Player = "Janko", Stars = 4 });
            var stars = starService.GetStars();
            Assert.AreEqual(1, stars.Count);
            Assert.AreEqual("Janko", stars[0].Player);
            Assert.AreEqual(4, stars[0].Stars);
        }

        [Test]
        public void PositiveAddStar2()
        {
            var starService = IStarService();
            starService.AddStar(new Star { Player = "Jaro", Stars = 4 });
            var stars1 = starService.GetStars();
            starService.AddStar(new Star { Player = "Kubo", Stars = 3 });
            stars1 = starService.GetStars();
            starService.AddStar(new Star { Player = "Janko", Stars = 2 });
            stars1 = starService.GetStars();
            Check("Jaro", 4, stars1[0].Player, stars1[0].Stars);
            Check("Kubo", 3, stars1[1].Player, stars1[1].Stars);
            Check("Janko", 2, stars1[2].Player, stars1[2].Stars);
        }

        [Test]
        public void NegativeAddTime1()
        {
            var starService = IStarService();
            starService.AddStar(new Star { Player = "Jaro", Stars = 4 });
            var stars1 = starService.GetStars();
            starService.AddStar(new Star { Player = "Kubo", Stars = 3 });
            stars1 = starService.GetStars();
            starService.AddStar(new Star { Player = "Janko", Stars = 2 });
            stars1 = starService.GetStars();
            Check("Jaro", 4, stars1[0].Player, stars1[0].Stars);
            Check("Kubo", 2, stars1[1].Player, stars1[1].Stars); //NEG!!!!!
            Check("Janko", 2, stars1[2].Player, stars1[2].Stars);
        }

        [Test]
        public void NegativeAddTime2()
        {
            var starService = IStarService();
            starService.AddStar(new Star { Player = "Janko", Stars = 4 });
            var stars1 = starService.GetStars();
            starService.AddStar(new Star { Player = "Kubo", Stars = 3 });
            var stars2 = starService.GetStars();
            starService.AddStar(new Star { Player = "Janko", Stars = 2 });
            var stars3 = starService.GetStars();
            Check("Janko", 4, stars1[0].Player, stars1[0].Stars);
            Check("Jan", 6, stars2[1].Player, stars1[1].Stars);  //NEG!!!!!
            Check("Janko", 2, stars3[2].Player, stars1[2].Stars);  //NEG!!!!!!
        }

        private void Check(string playerToCheck, int intToCheck, string player, int timeInSeconds)
        {
            Assert.AreEqual(playerToCheck, player);
            Assert.AreEqual(intToCheck, timeInSeconds);
        }
    }
}