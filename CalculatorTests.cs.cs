using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;    
using System;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_With10And5_Returns15()
        {
            double result = Calculator.Add(10, 5);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Multiply_With10And5_Returns50()
        {
            double result = Calculator.Multiply(10, 5);
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void Divide_With10And5_Returns2()
        {
            double result = Calculator.Divide(10, 5);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Subtract_With10And5_Returns5()
        {
            double result = Calculator.Subtract(10, 5);
            Assert.AreEqual(5, result);
        }

        // Extra: verifies division-by-zero handling
        [TestMethod]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Calculator.Divide(10, 0));
        }
    }
}

