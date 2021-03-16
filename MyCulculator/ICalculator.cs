using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCulculator
{
    /// <summary>
    /// Methods of the calculator.
    /// </summary>
    interface ICalculator
    {
        /// <summary>
        /// Clear the first number.
        /// </summary>
        void Clear();
        /// <summary>
        /// Multiplication.
        /// </summary>
        /// <param name="b"> The secons number. </param>
        double Multiplication(double b);
        /// <summary>
        /// Division.
        /// </summary>
        /// <param name="b"> Число. </param>
        double Division(double b);
        /// <summary>
        /// Sum.
        /// </summary>
        /// <param name="b"> The second number. </param>
        double Sum(double b);
        /// <summary>
        /// Substraction.
        /// </summary>
        /// <param name="b"> The second number. </param>
        double Substraction(double b);
        /// <summary>
        /// Cos().
        /// </summary>
        double Cos();
        /// <summary>
        /// Degree 1/2.
        /// </summary>
        double Notch();
        /// <summary>
        /// One diveded by number.
        /// </summary>
        double OneDivNumber();
        /// <summary>
        /// Clear memory.
        /// </summary>
        void MemoryClear();
    }
}
