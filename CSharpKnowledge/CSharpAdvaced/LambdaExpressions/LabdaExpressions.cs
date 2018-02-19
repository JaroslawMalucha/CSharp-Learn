using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.LambdaExpressions
{
    class LabdaExpressions
    {
        delegate void DisplayMessage();
        delegate int Multiply(int n);

        public static void testLambdaExpressions()
        {
            //// LAMBDA EXPRESSIONS:
            // - an anonymous function,i.e.: 
            //   - one without its own demarcated context /scope and one that has direct access to the scope its declared in)
            //   - without signature definition of: accessor, rest is inferred
            // - a special kind of a delegate that points to a function
            // - intresting is that this allows to move back the execution into any space, i.e. any line in the application giving you access to its state as a side-efect
            // - a shorter version of an anonymous method


            // ex1
            int res = 0;
            int arg = 3;
            int mult = 5;

            System.Func<int,int> func =  (x => x * mult);
            res = func(arg);
            res = otherContext(func);

            //ex2
            BookRepository.testBookRepo();

            //ex3
            Multiply MultiplyNumber = delegate (int n) { return n * 3; }; // anonymous function as a delegate
            Multiply MultiplyNumber2 = n => n * 3; // lambda expression
            Console.WriteLine(MultiplyNumber(30));
            Console.WriteLine(MultiplyNumber2(30));

            //ex4
            DisplayMessage Message = delegate { Console.WriteLine("Hi from the anonymous method."); };
            DisplayMessage Message2 = () => Console.WriteLine("Hi from the lambda expression.");

        }


        public static int otherContext(System.Func<int,int> func)
        {
            return func(7);
        }


    }
}
