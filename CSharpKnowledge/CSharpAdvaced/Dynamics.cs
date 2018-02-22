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

            dynamic value = 0;
            Console.WriteLine("Value is " + value);
            Console.WriteLine("Value type is " + value.GetType().Name);
            Console.WriteLine();

            value = "Game of Thrones";
            Console.WriteLine("Value is " + value);
            Console.WriteLine("Value type is " + value.GetType().Name);
            Console.WriteLine();

            value = new Animals();
            value.Name = "Dog";
            Console.WriteLine("Value is " + value.Name);
            Console.WriteLine("Value type is " + value.GetType().Name);
            Console.WriteLine();







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


            // var vs dynamic
            // var: 
            //  - syntax candy
            //  - strong, static typing
            //  - type assumed at initialization that needs to happen on declaration (compile-time type checking)
            //  - type cannot change
            //  - type safe
            //  - full intellisense
            //  - cannot be declared as parameter
            // dynamic:
            //  - actual feature
            //  - weak, dynamic typing
            //  - type assumed at each assignment (only runtime-checking of methods and type(operators, casting))
            //  - type changes at each assignment
            //  - not type safe
            //  - no intellisense
            //  - can be declared as parameter


        }


        class Animals
        {
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

        }
    }
}
