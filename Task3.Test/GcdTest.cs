using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task3.Test
{
    [TestClass]
    public class GcdTest
    {
        [TestMethod]
        public void GetSimpleEuclidGcdTest()
        {
            int a = 3;
            int b = 7;
            TimeSpan period;
            
            int result = Gcd.GetEuclidGcd(out period, a, b);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetEuclidGcdTest()
        {
            int a = 36;
            int b = 21;
            TimeSpan period;

            int result = Gcd.GetEuclidGcd(out period, a, b);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetEuclidGcdNullTest()
        {
            int a = 0;
            int b = 1;
            TimeSpan period;

            Gcd.GetEuclidGcd(out period, a, b);
        }

        [TestMethod]
        public void GetEuclidGcdFromOneTest()
        {
            int a = 1;
            int b = 5;
            TimeSpan period;

            int result = Gcd.GetEuclidGcd(out period, a, b);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetEuclidGcdThreeArgsTest()
        {
            int a = 100;
            int b = 5;
            int c = 10;
            TimeSpan period;

            int result = Gcd.GetEuclidGcd(out period, a, b, c);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void GetEuclidGcdManyArgsTest()
        {
            int[] array = new[] {9, 15, 21, 33, 99, 102};
            TimeSpan period;

            int result = Gcd.GetEuclidGcd(out period, array);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetSimpleBinaryGcdTest()
        {
            int a = 3;
            int b = 7;
            TimeSpan period;

            int result = Gcd.GetBinaryGcd(out period, a, b);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetBinaryGcdTest()
        {
            int a = 36;
            int b = 21;
            TimeSpan period;

            int result = Gcd.GetBinaryGcd(out period, a, b);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetBinaryGcdNullTest()
        {
            int a = 0;
            int b = 1;
            TimeSpan period;

            Gcd.GetBinaryGcd(out period, a, b);
        }

        [TestMethod]
        public void GetBinaryGcdFromOneTest()
        {
            int a = 1;
            int b = 5;
            TimeSpan period;

            int result = Gcd.GetBinaryGcd(out period, a, b);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetBinaryGcdThreeArgsTest()
        {
            int a = 100;
            int b = 5;
            int c = 10;
            TimeSpan period;

            int result = Gcd.GetBinaryGcd(out period, a, b, c);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void GetBinaryGcdManyArgsTest()
        {
            int[] array = new[] { 9, 15, 21, 33, 99, 102 };
            TimeSpan period;

            int result = Gcd.GetEuclidGcd(out period, array);

            Assert.AreEqual(3, result);
        }
    }
}
