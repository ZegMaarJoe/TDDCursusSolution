using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taken;

namespace DePalindroomTest
{
    [TestClass]
    public class WoordTest
    {
        [TestMethod]
        public void LepelIsEenPalindroom()
        {
            Assert.IsTrue(new Woord("lepel").IsPalindroom());
        }

        [TestMethod]
        public void VorkIsGeenPalindroom()
        {
            Assert.IsFalse(new Woord("vork").IsPalindroom());
        }

    }
}
