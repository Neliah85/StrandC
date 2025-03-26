using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrandC;
using System;

namespace StrandC
{
    [TestClass]
    public class FurdoTelepulesTest
    {
        [TestMethod]
        public void Telepules_HelyesCim()
        {
            Furdo furdo = new Furdo("Hévízi Gyógyfürdő;8380 Hévíz, Festetics tér 1.;5000;38");
            Assert.AreEqual("Hévíz", furdo.Telepules());
        }

        [TestMethod]
        public void Telepules_TobbSzavasTelepules()
        {
            Furdo furdo = new Furdo("Keszthelyi Helikon Strandfürdő;8360 Keszthely, Petőfi sétány 1.;2500;22");
            Assert.AreEqual("Keszthely", furdo.Telepules());
        }

       
    }
}