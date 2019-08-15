using Microsoft.VisualStudio.TestTools.UnitTesting;
using GCDLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDLib.Tests
{
    [TestClass()]
    public class GCDTests
    {
        [TestMethod()]
        public void GCDEuclideanExpected1 ()
        {
            long time=0;
            Assert.AreEqual(1, GCD.GCDEuclidean(out time, 444, 1080, 268, 247));
        }
        [TestMethod()]
        public void GCDEuclideanExpected12()
        {
            long time = 0;
            Assert.AreEqual(12, GCD.GCDEuclidean(out time, 252, 444, 1080, - 876));
        }
        [TestMethod()]
        public void GCDEuclideanExpected4()
        {
            long time = 0;
            Assert.AreEqual(4, GCD.GCDEuclidean(out time, 252, 4424, 1080, 0));
        }
        [TestMethod()]
        public void SteinGCDExpected1()
        {
            long time = 0;
            Assert.AreEqual(1, GCD.SteinGCD(out time, 444, 1080, 268, 247));
        }
        [TestMethod()]
        public void SteinGCDExpected12()
        {
            long time = 0;
            Assert.AreEqual(12, GCD.SteinGCD(out time, 252, 444, 1080, -876));
        }
        [TestMethod()]
        public void SteinGCDExpected4()
        {
            long time = 0;
            Assert.AreEqual(4, GCD.SteinGCD(out time, 252, 4424, 1080, 0));
        }
    }
}