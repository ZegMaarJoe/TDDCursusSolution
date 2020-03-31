using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExamenLibrary;

namespace ExamenLibraryTest
{
    [TestClass]
    public class PersoonTest
    {
        // Verwachte fouten
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenLegeStringIsFoutief()
        {
            new Persoon(new List<string> { "" });
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenLegeLijstIsFoutief()
        {
            new Persoon(new List<string> { });
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenLegeStringIsFoutiefNaEenGeldigeNaam()
        {
            new Persoon(new List<string> { "Peter", "" });
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenLegeStringIsFoutiefVoorEenGeldigeNaam()
        {
            new Persoon(new List<string> { "", "Peter" });
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenPersoonKanGeenTweeDezelfdeVoornamenHebben()
        {
            Persoon persoon = new Persoon(new List<string> { "Peter", "Peter" });
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenPersoonKanGeenDezelfdeVoornaamHebbenOpDrieNamen()
        {
            Persoon persoon = new Persoon(new List<string> { "Peter", "Heikel", "Peter" });
        }


        // Verwacht correcte ingave
        [TestMethod]
        public void EenPersoonKan1VoornaamHebben()
        {
            new Persoon(new List<string> { "Peter"});
        }

        [TestMethod]
        public void EénTekenVoorEenNaamIsGenoeg()
        {
            new Persoon(new List<string> { "P" });
        }

        [TestMethod]
        public void EenPersoonKanInitielenHebben()
        {
            new Persoon(new List<string> { "Peter", "P", "H" });
        }

        [TestMethod]
        public void ToStringGeeftDeVoornamenWeerGescheidenDoorEenSpatie()
        {
            Persoon persoon = new Persoon(new List<string> { "Peter", "Pettigrew" });
            Assert.AreEqual("Peter Pettigrew", persoon.ToString());
        }

        [TestMethod]
        public void ToStringGeeftDeVoornamenWeerGescheidenDoorEenSpatieMetDrieNamen()
        {
            Persoon persoon = new Persoon(new List<string> { "Peter", "Pettigrew", "Andersson" });
            Assert.AreEqual("Peter Pettigrew Andersson", persoon.ToString());
        }
    }
}
