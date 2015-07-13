using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace Task1.Test
{
    [TestClass]
    public class CustomMathTest
    {
        [TestMethod]
        public void CorrectPowTest()
        {
            double a = 27;
            int n = 3;
            double epsilon = 0.001;

            double result1 =  Math.Round(CustomMath.Pow(a, n, epsilon), 3);
            double result2 =  Math.Round(Math.Pow(a, (double)1/n), 3);

            Assert.AreEqual(result2, result1);
        }

        [TestMethod]
        public void NullNumberPowTest()
        {
            double a = 0;
            int n = 1;
            double epsilon = 0.001;

            double result1 = Math.Round(CustomMath.Pow(a, n, epsilon), 3);
            double result2 = Math.Round(Math.Pow(a, (double)1 / n), 3);

            Assert.AreEqual(result2, result1);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullPowerPowTest()
        {
            double a = 27;
            int n = 0;
            double epsilon = 0.001;
            
            double result1 = Math.Round(CustomMath.Pow(a, n, epsilon), 3);
        }

        [TestMethod]
        public void NegativeNumberCorrectPowTest()
        {
            double a = -27;
            int n = 3;
            double epsilon = 0.001;

            double result1 = Math.Round(CustomMath.Pow(a, n, epsilon), 3);
            double result2 = -3.000;

            Assert.AreEqual(result2, result1);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeNumberIncorrectPowTest()
        {
            double a = -9;
            int n = 2;
            double epsilon = 0.001;

            double result1 = Math.Round(CustomMath.Pow(a, n, epsilon), 3);
        }
    }
}
