using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class Dynamics
    {

        public static void testDynamics()
        {
            // Staticaly Typed languages: at compile time
            // Dynamicaly Typed languages: at run-time

            object o = "Mosh";
            o.GetHashCode();

            var methodInfo = o.GetType().GetMethod("GetHashCode");
            //methodInfo.Invoke(null, null);

            object excelObject = "mosh";
            //excelObject.Optimize(); //does not compile on object type
            dynamic excelDynamic = " mosh";
            //excelDynamic.Optimzie(); // does compile and will be checked at runtime

            dynamic name = "Mosh";
            try
            {
                name++;
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot use ++ operator on non numeric types");
            }
            name = 10; //the name variable changes type at runtime; just like VBA Variant
            name++;//this works

            dynamic a = 10;
            dynamic b = 2;
            var c = a + b;// c becomes a dynamic
            


        }

    }
}
