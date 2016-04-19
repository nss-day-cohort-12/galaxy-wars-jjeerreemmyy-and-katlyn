using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GalaxyWars;


namespace UnitTestGalaxyWars
{
    [TestClass]
    public class DraeneiTest
    {
        [TestMethod]
        public void DefineDraenei()
        {
            Draenei dan = new Draenei();
            Assert.AreSame(dan.starType, "BlackHole");
            Assert.AreEqual(dan.Desc(), "hooved aliens");
            Assert.AreEqual(dan.hasHooves, true);

        }
    }
}
