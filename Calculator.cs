﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    /// <summary>
    /// Simple Calculator with Add, Multiply, Divide, Subtract.
    /// Methods are static so tests can call them easily.
    /// </summary>
    public class Calculator
    {
        public static double Add(double a, double b) => a + b;

        public static double Multiply(double a, double b) => a * b;

        public static double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return a / b;
        }

        public static double Subtract(double a, double b) => a - b;
    }
}