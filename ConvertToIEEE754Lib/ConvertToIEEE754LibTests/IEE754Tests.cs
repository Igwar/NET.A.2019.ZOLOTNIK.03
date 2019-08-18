using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConvertToIEEE754Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToIEEE754Lib.Tests
{
    [TestClass()]
    public class IEE754Tests
    {
        [TestMethod()]
        public void ConvertToIEEE754255255()
        {
            
            double test = 255.255;
            Assert.AreEqual("0100000001101111111010000010100011110101110000101000111101011100", test.ConvertIEE754());
        }
        [TestMethod()]
        public void ConvertToIEEE754Negative255255()
        {
         
            double test = -255.255;
            Assert.AreEqual("1100000001101111111010000010100011110101110000101000111101011100", test.ConvertIEE754());
        }
        [TestMethod()]
        public void ConvertToIEEE7544294967295()
        {
         
            double test = 4294967295.0;
            Assert.AreEqual("0100000111101111111111111111111111111111110000000000000000000000", test.ConvertIEE754());
        }
        [TestMethod()]
        public void ConvertToIEEE754NegativeInfinity()
        {
           
            double test = double.NegativeInfinity;
            Assert.AreEqual("1111111111100000000000000000000000000000000000000000000000000000", test.ConvertIEE754());
        }
        [TestMethod()]
        public void ConvertToIEEE754PositiveInfinity()
        {
            
            double test = double.PositiveInfinity;
            Assert.AreEqual("0111111111100000000000000000000000000000000000000000000000000000", test.ConvertIEE754());
        }
        [TestMethod()]
        public void ConvertToIEEE754NaN()
        {
        
            double test = double.NaN;
            Assert.AreEqual("1111111111000000000000000000000000000000000000000000000000000000", test.ConvertIEE754());
        }
    }
}