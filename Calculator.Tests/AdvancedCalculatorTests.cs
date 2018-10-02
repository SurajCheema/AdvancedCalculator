using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestFixture]
    public class AdvancedCalculatorTests
    {
        /// <summary>
        /// The unit under test
        /// </summary>
        private CalculatorNS.Calculator _uut;

        /// <summary>
        /// Test that the correct value is returned when multiplication occurs after
        /// subtraction in the infix equation.
        /// </summary>
        [Test]
        public void TestMixedPrecedenceWithMultiplication()
        {
            string input = "20 - 10 * 3";
            int expectedResult = -10;
            Assert.Fail("Need to implement");
        }

        /// <summary>
        /// Test that the correct value is returned when division occurs after
        /// addition in the infix equation.
        /// </summary>
        [Test]
        public void TestMixedPrecedenceWithDivision()
        {
            string input = "20 + 10 / 2";
            int expectedResult = 25;
            Assert.Fail("Need to implement");
        }

        /// <summary>
        /// Test where parentheses are used to supersede division in an equation.
        /// </summary>
        [Test]
        public void TestMixedPrecedenceWithParentheses()
        {
            string input = "(20 + 10) / 2";
            int expectedResult = 15;
            Assert.Fail("Need to implement");
        }
    }
}
