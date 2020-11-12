using System;
using MyCarRace.CarRaceModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFactory()
        {
            Punter punter = Factory.GetPunter("Olivia");
            bool result = punter is Olivia;
            Assert.AreEqual(result, true);
        }
    }
}
