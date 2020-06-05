using NUnit.Framework;
using Pexeso.PexesoCore.Core;

namespace PexesoTests
{
    public class CoreTests
    {
        [Test]
        public void PositiveCell()
        {
            Cell cell = new Cell('A');
            Assert.AreEqual('A', cell.Value);
        }

        [Test]
        public void NegativeCell()
        {
            Cell cell = new Cell('A');
            Assert.AreEqual('B', cell.Value);
        }
    }
}