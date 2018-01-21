using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.LambdaExpressions
{
    class LabdaExpressions
    {
        public static void testLambdaExpressions()
        {
            //// LAMBDA EXPRESSIONS:
            // - an anonymous function,i.e.: 
            //   - one without its own demarcated context /scope and one that has direct access to the scope its declared in)
            //   - without signature definition of: accessor, rest is inferred
            // - a special kind of a delegate that points to a function
            // - intrestinh is that this allows to move back the execution into any space, i.e. any line in the application giving you access to its state as a side-efect



            int res = 0;
            int arg = 3;
            int mult = 5;

            System.Func<int,int> func =  (x => x * mult);
            res = func(arg);
            res = otherContext(func);


            BookRepository.testBookRepo();
        }


        public static int otherContext(System.Func<int,int> func)
        {
            return func(7);
        }


    }
}
