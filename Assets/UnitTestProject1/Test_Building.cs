using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Village_TD;

namespace UnitTestProject1
{
    [TestClass]
    public class Test_Building
    {
        [TestMethod]
        public void TestmaxLevelPopulations()
        {
            House h = new House();
            

            Assert.AreEqual(h.Level, 1, "initial level should be 1");
            Assert.AreEqual(h.MaxPopulation, House.maxLevelPopulations[h.Level - 1], "MaxPopulation is incorrect");
        }

        [TestMethod]
        public void Testupgrade()
        {
            House h = new House();
            int level = h.Level;
            h.upgrade();
            Assert.AreEqual(h.Level,level +1, "method upgrade does not work");
           
        }

        [TestMethod]
        public void Testcreatetroops()
        {
            Barrack b = new Barrack();
            b.createSwordfighter();
            
            Assert.AreEqual(b.Swordfighters, 1, "method createswordfighter does not work");

        }

    }
}
