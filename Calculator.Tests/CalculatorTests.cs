using System;
using NUnit.Framework;
using CalculatorNS;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        /// <summary>
        /// The unit under test
        /// </summary>
        private CalculatorNS.Calculator _uut;


        /// <summary>
        /// Test a simple addition.
        /// </summary>
        [Test]
        public void TestSimpleAddition()
        {
            string input = "1 + 2";
            int expectedResult = 3;
            Assert.Fail("Need to implement");
        }

        /// <summary>
        /// Test a simple subtraction.
        /// </summary>
        [Test]
        public void TestSimpleSubtraction()
        {
            string input = "2 - 1";
            int expectedResult = 1;
            Assert.Fail("Need to implement");
        }

        /// <summary>
        /// Test a simple multiplication.
        /// </summary>
        [Test]
        public void TestSimpleMultiplication()
        {
            string input = "2 * 2";
            int expectedResult = 4;
            Assert.Fail("Need to implement");
        }

        /// <summary>
        /// Test a simple division.
        /// </summary>
        [Test]
        public void TestSimpleDivision()
        {
            string input = "10 / 2";
            int expectedResult = 5;
            Assert.Fail("Need to implement");
        }

        /// <summary>
        /// Test where a chain of additions are processed.
        /// </summary>
        [Test]
        public void TestChainAddition()
        {
            string input = "1 + 2 + 3";
            int expectedResult = 6;
            Assert.Fail("Need to implement");
        }

        /// <summary>
        /// Test where a chain of subtractions are processed.
        /// </summary>
        [Test]
        public void TestChainSubtraction()
        {
            string input = "3 - 2 - 1";
            int expectedResult = 0;
            Assert.Fail("Need to implement");
        }

        /// <summary>
        /// Test where a chain of multiplications are processed.
        /// </summary>
        [Test]
        public void TestChainMultiplication()
        {
            string input = "2 * 2 * 2";
            int expectedResult = 8;
            Assert.Fail("Need to implement");
        }

        /// <summary>
        /// Test where a chain of divisions are processed.
        /// </summary>
        [Test]
        public void TestChainDivision()
        {
            string input = "12 / 3 / 2";
            int expectedResult = 2;
            Assert.Fail("Need to implement");
        }

        /// <summary>
        /// Test where an addition and a subtraction are processed.
        /// </summary>
        [Test]
        public void TestAdditionAndSubtraction()
        {
            string input = "1 + 5 - 2";
            int expectedResult = 4;
            Assert.Fail("Need to implement");
        }

        /// <summary>
        /// Test where a subtraction and addition are processed.
        /// </summary>
        [Test]
        public void TestSubtractionAndAddition()
        {
            string input = "10 - 2 + 4";
            int expectedResult = 12;
            Assert.Fail("Need to implement");
        }

        /// <summary>
        /// Test where a multiplication and division are processed.
        /// </summary>
        [Test]
        public void TestMultiplicationAndDivision()
        {
            string input = "5 * 4 / 2";
            int expectedResult = 10;
            Assert.Fail("Need to implement");
        }

        /// <summary>
        /// Test where a division and multiplication are processed.
        /// </summary>
        [Test]
        public void TestDivisionAndMultiplication()
        {
            string input = "20 / 2 * 1";
            int expectedResult = 10;
            Assert.Fail("Need to implement");
        }

        /// <summary>
        /// Test that the correct exception is thrown when a sum attempts to divide
        /// by zero.
        /// </summary>
        [Test]
        public void TestDivideByZero()
        {
            string input = "30 / 0";
            var ex = Assert.Throws<DivideByZeroException>(
                () => _uut.Calculate(input)
                );
            Assert.IsTrue(ex.Message.Contains("My divide by zero message"));
        }

    }

} // namespace CalculatorTests
