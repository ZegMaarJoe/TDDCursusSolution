using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class LandServiceTest
    {
        private ILandDAO landDAO;
        private LandService landService;

        [TestInitialize]
        public void Initialize()
        {
            landDAO = new LandDAOStub();
            landService = new LandService(landDAO);
        }

        [TestMethod]
        public void VindVerhoudingOppLandTotOppAlleLanden()
        {
            Assert.AreEqual(0.25m, landService.VindVerhoudingOppTotOppVanAlleLanden("B"));
        }
    }
}
