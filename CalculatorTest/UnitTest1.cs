using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCulculator;

namespace CalculatorTest
{
    /// <summary>
    /// Unit-test for class Calculator
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        Calculator calc = new Calculator();
        /// <summary>
        /// Sum of positiv numbers.
        /// </summary>
        [TestMethod]
        public void TestSumPositiv()
        {
            calc.Put_a = 20;
            double expected = 55, result;
            result = calc.Sum(35);
            Assert.AreEqual(expected, result);

        }

        /// <summary>
        /// Sum of numbers with different signs.
        /// </summary>
        [TestMethod]
        public void TestSumDifferent()
        {
            double expected = -15, result;
            calc.Put_a = 20;
            result = calc.Sum(-35);
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Multiplication of positiv numbers.
        /// </summary>
        [TestMethod]
        public void TestMulPositiv()
        {
            double expected = 350, result;
            calc.Put_a = 10;
            result = calc.Multiplication(35);
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Multiplication of numbers with different signs.
        /// </summary>
        [TestMethod]
        public void TestMulDifferent()
        {
            double expected = 350, result;
            calc.Put_a = -10;
            result = calc.Multiplication(-35);
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Division of positiv numbers.
        /// </summary>
        [TestMethod]
        public void TestDivPositiv()
        {
            double expected = 35, result;
            calc.Put_a = 350;
            result = calc.Division(10);
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Division of numbers with different signs.
        /// </summary>
        [TestMethod]
        public void TestDivDifferent()
        {
            double expected = 35, result;
            calc.Put_a = -350;
            result = calc.Division(-10);
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Substraction of numbers with different signs.
        /// </summary>
        [TestMethod]
        public void TestSubDifferent()
        {
            double expected = -35, result;
            calc.Put_a = 200;
            result = calc.Substraction(235);
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Substraction of negative numbers.
        /// </summary>
        [TestMethod]
        public void TestSubNegative()
        {
            double expected = -165, result;
            calc.Put_a = -200;
            result = calc.Substraction(-35);
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// The positiv number in degree 1/2.
        /// </summary>
        [TestMethod]
        public void TestNotchPositiv()
        {
            double expected = 5, result;
            calc.Put_a = 25;
            result = calc.Notch();
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Cos of positiv number.
        /// </summary>
        [TestMethod]
        public void TestCosPositiv()
        {
            double expected = 0.15, result;
            calc.Put_a = 30;
            result = calc.Cos();
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Cos of negativ number.
        /// </summary>
        [TestMethod]
        public void TestCosNegativ()
        {
            double expected = -0.95, result;
            calc.Put_a = 60;
            result = calc.Cos();
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// One divided by positiv number.
        /// </summary>
        [TestMethod]
        public void TestOneDivNumberPositiv()
        {
            double expected = 0.04, result;
            calc.Put_a = 25;
            result = calc.OneDivNumber();
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// One divided by negativ number.
        /// </summary>
        [TestMethod]
        public void TestOneDivNumberNegativ()
        {
            double expected = -0.04, result;
            calc.Put_a = -25;
            result = calc.OneDivNumber();
            Assert.AreEqual(expected, result);
        }
    }
}
