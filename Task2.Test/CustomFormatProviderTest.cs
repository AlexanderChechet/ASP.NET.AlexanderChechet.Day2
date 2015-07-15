using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task2.Test
{
    [TestClass]
    public class CustomFormatProviderTest
    {
        [TestMethod]
        public void DecToHexCorrectTest()
        {
            string result = String.Format(new CustomFormatProvider(), "{0:H}", 33);

            Assert.AreEqual("21", result);
        }

        [TestMethod]
        public void DecToHexNullFormatTest()
        {
            string result = String.Format(new CustomFormatProvider(), "{0}", 33);

            Assert.AreEqual("33", result);
        }
    }
}
