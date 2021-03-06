﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;
using Moq;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class LandServiceTest
    {
        private ILandDAO landDAO;
        private Mock<ILandDAO> mockFactory;
        private LandService landService;

        [TestInitialize]
        public void Initialize()
        {
            mockFactory = new Mock<ILandDAO>();
            landDAO = mockFactory.Object;

            mockFactory.Setup(eenLandDAO => eenLandDAO.Read(string.Empty)).Throws(new ArgumentException());

            mockFactory.Setup(eenlandDAO => eenlandDAO.OppervlakteAlleLanden()).Returns(20);

            mockFactory.Setup(eenLandDAO => eenLandDAO.Read("B")).Returns(new Land { Landcode = "B", Oppervlakte = 5 });
         
            mockFactory.Setup(eenLandDAO => eenLandDAO.Read("NL")).Returns(new Land { Landcode = "NL", Oppervlakte = 6 });

            landService = new LandService(landDAO);
        }

        [TestMethod]
        public void VindVerhoudingOppLandTotOppAlleLanden()
        {
            Assert.AreEqual(0.25m, landService.VindVerhoudingOppTotOppVanAlleLanden("B"));
        }
    }
}
