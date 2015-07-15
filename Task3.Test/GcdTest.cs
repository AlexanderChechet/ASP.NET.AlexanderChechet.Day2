using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task3.Test
{
    [TestClass]
    public class GcdTest
    {
        [TestMethod]
        public void SimpleEuclidGcdTimeTest()
        {
            int a = 3;
            int b = 7;
            long period;
            
            int result = Gcd.EuclidGcd(out period, a, b);
            Debug.WriteLine(period);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void EuclidGcdTimeTest()
        {
            int a = 36;
            int b = 21;
            long period;

            int result = Gcd.EuclidGcd(out period, a, b);
            Debug.WriteLine(period);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void EuclidGcdNullTimeTest()
        {
            int a = 0;
            int b = 1;
            long period;

            int result = Gcd.EuclidGcd(out period, a, b);
            Debug.WriteLine(period);

            Assert.AreEqual(1 ,result);
        }

        [TestMethod]
        public void EuclidGcdFromOneTimeTest()
        {
            int a = 1;
            int b = 5;
            long period;

            int result = Gcd.EuclidGcd(out period, a, b);
            Debug.WriteLine(period);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void EuclidGcdThreeArgsTimeTest()
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
        public void EuclidGcdManyArgsTimeTest()
        {
            int[] array = new[] {9, 15, 21, 33, 99, 102};
            long period;

            int result = Gcd.EuclidGcd(out period, array);
            Debug.WriteLine(period);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SimpleSteinGcdTimeTest()
        {
            int a = 3;
            int b = 7;
            long period;

            int result = Gcd.SteinGcd(out period, a, b);
            Debug.WriteLine(period);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SteinGcdTimeTest()
        {
            int a = 36;
            int b = 21;
            long period;

            int result = Gcd.SteinGcd(out period, a, b);
            Debug.WriteLine(period);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SteinGcdNullTimeTest()
        {
            int a = 0;
            int b = 1;
            long period;

            int result = Gcd.SteinGcd(out period, a, b);
            Debug.WriteLine(period);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SteinGcdFromOneTimeTest()
        {
            int a = 1;
            int b = 5;
            long period;

            int result = Gcd.SteinGcd(out period, a, b);
            Debug.WriteLine(period);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SteinGcdThreeArgsTimeTest()
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
        public void SteinGcdManyArgsTimeTest()
        {
            int[] array = new[] { 9, 15, 21, 33, 99, 102 };
            long period;

            int result = Gcd.EuclidGcd(out period, array);
            Debug.WriteLine(period);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SimpleEuclidGcdWithoutTimeTest()
        {
            int a = 3;
            int b = 7;

            int result = Gcd.EuclidGcd(a, b);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void EuclidGcdWithoutTimeTest()
        {
            int a = 36;
            int b = 21;

            int result = Gcd.EuclidGcd(a, b);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void EuclidGcdNullWithoutTimeTest()
        {
            int a = 0;
            int b = 1;

            int result = Gcd.EuclidGcd(a, b);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void EuclidGcdFromOneWithoutTimeTest()
        {
            int a = 1;
            int b = 5;

            int result = Gcd.EuclidGcd(a, b);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void EuclidGcdThreeArgsWithoutTimeTest()
        {
            int a = 100;
            int b = 5;
            int c = 10;

            int result = Gcd.EuclidGcd(a, b, c);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void EuclidGcdManyArgsWithoutTimeTest()
        {
            int[] array = new[] { 9, 15, 21, 33, 99, 102 };

            int result = Gcd.EuclidGcd(array);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SimpleSteinGcdWithoutTimeTest()
        {
            int a = 3;
            int b = 7;

            int result = Gcd.SteinGcd(a, b);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SteinGcdWithoutTimeTest()
        {
            int a = 36;
            int b = 21;

            int result = Gcd.SteinGcd(a, b);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SteinGcdNullWithoutTimeTest()
        {
            int a = 0;
            int b = 1;

            int result = Gcd.SteinGcd(a, b);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SteinGcdFromOneWithoutTimeTest()
        {
            int a = 1;
            int b = 5;

            int result = Gcd.SteinGcd(a, b);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SteinGcdThreeArgsWithoutTimeTest()
        {
            int a = 100;
            int b = 5;
            int c = 10;

            int result = Gcd.SteinGcd(a, b, c);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void SteinGcdManyArgsWithoutTimeTest()
        {
            int[] array = new[] { 9, 15, 21, 33, 99, 102 };

            int result = Gcd.EuclidGcd(array);

            Assert.AreEqual(3, result);
        }
    }
}
