using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taken;

namespace TakenTest
{
    [TestClass]
    public class VeilingTest
    {
        [TestMethod]
        public void BijStartVanHetProgrammaIsBod0()
        {
            var veiling = new Veiling();
            Assert.AreEqual(decimal.Zero, veiling.HoogsteBod);
        }
        [TestMethod]
        public void DoeEenEersteBodEnControleer()
        {
            var veiling = new Veiling();
            var bedrag = 25m;
            veiling.DoeBod(bedrag);
            Assert.AreEqual(bedrag, veiling.HoogsteBod);
        }
        [TestMethod]
        public void DoeEenHogerBodEnControleer()
        {
            var veiling = new Veiling();
            var bedrag = 200m;
            var hogerBedrag = 1000m;
            veiling.DoeBod(bedrag);
            veiling.DoeBod(hogerBedrag);
            Assert.AreEqual(hogerBedrag, veiling.HoogsteBod);
        }
    }
}
