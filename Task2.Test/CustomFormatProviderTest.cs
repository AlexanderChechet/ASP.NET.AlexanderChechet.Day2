using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task2.Test
{
    [TestClass]
    public class CustomFormatProviderTest
    {
        [TestMethod]
        public void DecToHexCorrectTest()
        {
            int number = 16;

            string result = String.Format(new CustomFormatProvider(), "{0:H}", 33);

            Assert.AreEqual("21", result);
        }

        [TestMethod]
        public void DecToHexNullFormatTest()
        {
            int number = 16;

            string result = String.Format(new CustomFormatProvider(), "{0}", 33);

            Assert.AreEqual("33", result);
        }
    }
}
