using System;
using System.Text.RegularExpressions;

namespace MyCulculator
{
    /// <summary>
    /// Calculator.
    /// </summary>
    public class Calculator : ICalculator
    {
        /// <summary>
        /// The first number.
        /// </summary>
        private double a = 0;
        /// <summary>
        /// Memory.
        /// </summary>
        private double memory = 0;
        /// <summary>
        /// Sum.
        /// </summary>
        /// <param name="b"> The second number. </param>
        /// <returns> Result. </returns>
        public double Sum(double b) => Math.Round(a + b, 2);
        /// <summary>
        /// Substraction.
        /// </summary>
        /// <param name="b"> The second number. </param>
        /// <returns> Result. </returns>
        public double Substraction(double b) => Math.Round(a - b, 2);
        /// <summary>
        /// Multiplication.
        /// </summary>
        /// <param name="b"> The second number. </param>
        /// <returns> Result. </returns>
        public double Multiplication(double b) => Math.Round(a * b, 2);
        /// <summary>
        /// Division.
        /// </summary>
        /// <param name="b"> The second number. </param>
        /// <returns> Result. </returns>
        public double Division(double b)
        {
            if (b == 0) throw new Exception("Error. Division by zero.");
            else return Math.Round(a / b, 2);
        }
        /// <summary>
        /// Cos().
        /// </summary>
        /// <returns> Result. </returns>
        public double Cos() => Math.Round(Math.Cos(a), 2);
        /// <summary>
        /// Degree 1/2.
        /// </summary>
        /// <returns> Result. </returns>
        public double Notch()
        {
            if (a < 0) throw new Exception("Error. Not a number");
            return Math.Round(Math.Sqrt(a), 2);
        }
        /// <summary>
        /// One diveded by number.
        /// </summary>
        /// <returns> Result. </returns>
        public double OneDivNumber()
        {
            if (a == 0) throw new Exception("Error. Division by zero.");
            return Math.Round(1 / a, 2);
        }
        /// <summary>
        /// Get/Set the first number.
        /// </summary>
        public double Put_a { get => a; set => a = value; }
        /// <summary>
        /// Get/Set the memory.
        /// </summary>
        public double Memory { get => memory; set => memory = value; }
        /// <summary>
        /// Clear the first number.
        /// </summary>
        public void Clear() => a = 0;
        /// <summary>
        /// Clear memory.
        /// </summary>
        public void MemoryClear() => memory = 0;
    }
}
