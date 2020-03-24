using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taken;

namespace TakenTest
{
    [TestClass]
    public class VeilingTest
    {
        private Veiling veiling;
        [TestInitialize]
        public void Initialize()
        {
            veiling = new Veiling();
        }
        [TestMethod]
        public void BijStartVanHetProgrammaIsBod0()
        {
            Assert.AreEqual(decimal.Zero, veiling.HoogsteBod);
        }
        [TestMethod]
        public void DoeEenEersteBodEnControleer()
        {
            var bedrag = 25m;
            veiling.DoeBod(bedrag);
            Assert.AreEqual(bedrag, veiling.HoogsteBod);
        }
        [TestMethod]
        public void DoeEenHogerBodEnControleer()
        {
            var bedrag = 200m;
            var hogerBedrag = 1000m;
            veiling.DoeBod(bedrag);
            veiling.DoeBod(hogerBedrag);
            Assert.AreEqual(hogerBedrag, veiling.HoogsteBod);
        }
    }
}
