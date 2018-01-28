using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.MathFunctions
{ 
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
                sum += num;
            return sum;
        }




        public static void TestCalculator()
        {
            Console.WriteLine(new Calculator().Add(1, 2, 3, 4, 5));
            Console.WriteLine(new Calculator().Add(new int[] { 1, 1, 1, 1, 1 }));

            Calculator casio = new Calculator();
            var result = casio.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
