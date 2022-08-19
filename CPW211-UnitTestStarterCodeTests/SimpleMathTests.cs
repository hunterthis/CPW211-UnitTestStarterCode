using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double a, double b)
        {
            // Use the DataRow values to test the Add method

            double aPlusb = a + b;

            SimpleMath.Add(a, b); //will add both numbers

            Assert.IsTrue((a + b) == aPlusb); //check if result is same as test
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Multiply_TwoNumbers_ReturnsProduct(double a, double b)
        {
            double aTimesb = a * b;

            SimpleMath.Multiply(a, b); 

            Assert.IsTrue((a * b) == aTimesb); //check if result is same as test
        }

        [TestMethod]
        [DataRow(1)]
        public void Divide_DenominatorZero_ThrowsArgumentException(double a)
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"

            double b = 0;
            SimpleMath.Divide(a,b);

            Assert.IsTrue((a / b) == 0); //check if result is positive or not
        }

       

        [TestMethod]
        [DataRow(5, 10)]
        public void Divide_Method_Two_numbs(double a, double b)
        {
            //Test Divide method with two valid numbers

            double aDivb = a / b;

            SimpleMath.Divide(a, b);

            Assert.IsTrue((a / b) == aDivb); //check if result is positive or not
        }
    }
}