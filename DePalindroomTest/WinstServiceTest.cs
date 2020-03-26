using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taken;

namespace TakenTest
{
    [TestClass]
    public class WinstServiceTest
    {
        private WinstService winstService;
        private IKostDAO kostDAO;
        private IOpbrengstDAO opbrengstDAO;

        [TestInitialize]
        public void initialize()
        {
            kostDAO = new KostDAOStub();
            opbrengstDAO = new OpbrengstDAOStub();
            winstService = new WinstService(opbrengstDAO, kostDAO);
        }

        [TestMethod]
        public void winstIsOpbrengstMinKost()
        {
            Assert.AreEqual(31m, winstService.Winst);
        }
    }
}
