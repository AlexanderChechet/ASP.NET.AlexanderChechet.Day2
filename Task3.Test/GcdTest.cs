using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task3.Test
{
    [TestClass]
    public class GcdTest
    {
        [TestMethod]
        public void SimpleEuclidGcdTest()
        {
            int a = 3;
            int b = 7;
            long period;
            
            int result = Gcd.EuclidGcd(out period, a, b);
            Debug.WriteLine(period);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void EuclidGcdTest()
        {
            int a = 36;
            int b = 21;
            long period;

            int result = Gcd.EuclidGcd(out period, a, b);
            Debug.WriteLine(period);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void EuclidGcdNullTest()
        {
            int a = 0;
            int b = 1;
            long period;

            int result = Gcd.EuclidGcd(out period, a, b);
            Debug.WriteLine(period);

            Assert.AreEqual(1 ,result);
        }

        [TestMethod]
        public void EuclidGcdFromOneTest()
        {
            int a = 1;
            int b = 5;
            long period;

            int result = Gcd.EuclidGcd(out period, a, b);
            Debug.WriteLine(period);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void EuclidGcdThreeArgsTest()
        {
            int a = 100;
            int b = 5;
            int c = 10;
            long period;

            int result = Gcd.EuclidGcd(out period, a, b, c);
            Debug.WriteLine(period);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void EuclidGcdManyArgsTest()
        {
            int[] array = new[] {9, 15, 21, 33, 99, 102};
            long period;

            int result = Gcd.EuclidGcd(out period, array);
            Debug.WriteLine(period);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SimpleSteinGcdTest()
        {
            int a = 3;
            int b = 7;
            long period;

            int result = Gcd.SteinGcd(out period, a, b);
            Debug.WriteLine(period);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SteinGcdTest()
        {
            int a = 36;
            int b = 21;
            long period;

            int result = Gcd.SteinGcd(out period, a, b);
            Debug.WriteLine(period);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SteinGcdNullTest()
        {
            int a = 0;
            int b = 1;
            long period;

            int result = Gcd.SteinGcd(out period, a, b);
            Debug.WriteLine(period);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SteinGcdFromOneTest()
        {
            int a = 1;
            int b = 5;
            long period;

            int result = Gcd.SteinGcd(out period, a, b);
            Debug.WriteLine(period);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SteinGcdThreeArgsTest()
        {
            int a = 100;
            int b = 5;
            int c = 10;
            long period;

            int result = Gcd.SteinGcd(out period, a, b, c);
            Debug.WriteLine(period);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void SteinGcdManyArgsTest()
        {
            int[] array = new[] { 9, 15, 21, 33, 99, 102 };
            long period;

            int result = Gcd.EuclidGcd(out period, array);
            Debug.WriteLine(period);

            Assert.AreEqual(3, result);
        }
    }
}
