using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.MathFunctions
{
    class MathFuncs
    {
        public static void testMathFunctions()
        {
            MathFunctions.MathFuncs.basicMathFunctions();
            MathFunctions.Calculator.TestCalculator();
            MathFunctions.Random.testRandom();
        }


        public static void basicMathFunctions()
        {
            double res = 0;
            double x = 5.553;
            res = Math.Ceiling(x);
            res = Math.Floor(x);
            res = Math.Round(x);
            res = Math.Truncate(x); //like Fix() in vba 
            res = Math.Sign(x);
            res = Math.Abs(-x);
            res = Math.PI;
            res = Math.E;
            res = Math.Exp(x); //e to x power
            res = Math.Pow(x,x);
            res = Math.Sqrt(x);
            res = Math.Max(x,x);
            res = Math.Min(x,x);
        }
    }
}
