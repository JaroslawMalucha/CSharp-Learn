using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    class RefLocalRefReturn
    {
        public static void test()
        {
            {
                // BY VALUE
                int X1 = 3;
                int X2 = X1; // by value -> copied the value of the variable
                X1 = 100;
                Console.WriteLine(X1);
                Console.WriteLine(X2);
                //prints different values
            }
            {
                // BY REFERENCE
                int X1 = 3;
                ref int X2 = ref X1;// by reference -> copied the reference to the variable containing the value
                X1 = 100;
                Console.WriteLine(X1);
                Console.WriteLine(X2);
                //prints the same
            }
            {
                // BY REFERENCE RETURN
                ref var returnValue = ref ReturnByReference();
                Console.WriteLine(returnValue);
            }
        }

        public static ref string ReturnByReference()
        {
            string[] arrayOfNames = { "Ella", "Liz", "Eve", "Claire" };
            return ref arrayOfNames[0];
        }
    }
}
