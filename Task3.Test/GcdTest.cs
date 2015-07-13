using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task3.Test
{
    [TestClass]
    public class GcdTest
    {
        [TestMethod]
        public void GetSimpleGcdTest()
        {
            int a = 3;
            int b = 7;
            TimeSpan period;
            
            int result = TypeWithGCD.GetGcd(out period, a, b);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetGcdTest()
        {
            int a = 36;
            int b = 21;
            TimeSpan period;

            int result = TypeWithGCD.GetGcd(out period, a, b);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetGcdNullTest()
        {
            int a = 0;
            int b = 1;
            TimeSpan period;

            TypeWithGCD.GetGcd(out period, a, b);
        }

        [TestMethod]
        public void GetGcdFromOneTest()
        {
            int a = 1;
            int b = 5;
            TimeSpan period;

            int result = TypeWithGCD.GetGcd(out period, a, b);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetGcdThreeArgsTest()
        {
            int a = 100;
            int b = 5;
            int c = 10;
            TimeSpan period;

            int result = TypeWithGCD.GetGcd(out period, a, b, c);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void GetGcdManyArgsTest()
        {
            int[] array = new[] {9, 15, 21, 33, 99, 102};
            TimeSpan period;

            int result = TypeWithGCD.GetGcd(out period, array);

            Assert.AreEqual(3, result);
        }
    }
}
