﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class RekeningTest
    {
        private Rekening rekening;
        [TestInitialize]
        public void Initialize()
        {
            rekening = new Rekening();
        }
        [TestMethod]
        public void HetSaldoVanEenNieuweRekeningIsNul()
        {
            Assert.AreEqual(decimal.Zero, rekening.Saldo);
        }
        [TestMethod]
        public void HetSaldoNaEenEersteStortingIsHetBedragVanDieStorting()
        {
            var bedrag = 2.5m;
            rekening.Storten(bedrag);
            Assert.AreEqual(bedrag, rekening.Saldo);
        }
        [TestMethod]
        public void HetSaldoNaTweeStortingenIsDeSomVanDieBedragen()
        {
            rekening.Storten(2.5m);
            rekening.Storten(1.2m);
            Assert.AreEqual(3.7m, rekening.Saldo);
        }
    }
}
