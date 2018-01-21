using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    class Types
    {
        // all variables are either:
        //-Structures:
        //  - Primitive Types
        //  - Custom Structures (structs)
        //- Classes:
        //  - Strings
        //  - Arrays
        //  - Other Collections
        //  - Custom classes

        // CHARACHTTERISTICS
        // Structures - VALUE TYPES
        //  allocated on stack
        //  memory allocation done automatically
        //  immediately removed when out of scope when exits its context on te stack
        // 
        // Classes - REFERENCE TYPES
        //  you need to allocate memory
        //  memory allocated on heap
        //  removed by garbage collector

        public static void testTypes()
        {
            ////ASSIGNMENT
            //VALUE TYPES
            var a = 19;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a:{0} b:{1}", a, b));

            //REFERENCE TYPES
            var arr1 = new int[] { 1, 2, 3 };
            var arr2 = arr1;
            arr1[0]++;
            Console.WriteLine(string.Format("array1: {0} array2: {1}", arr1[0], arr2[0]));


            ////PASSING PARAMETERS - DEFAULT BY VALUE
            //VALUE TYPES
            int number = 2;
            Increment(number);
            Console.WriteLine(number);
            //REFERENCE TYPES
            var person1 = new Person() { Age = 20 };
            var person2 = person1;
            MakeOld(person: person1);
            Console.WriteLine(string.Format("person1: {0} person2: {1}", person1.Age, person2.Age));
            Console.WriteLine(string.Format("person1: {0} person2: {1}", person1, person2));

            




        }

        public static void Increment(int number)
        {
            number += 10;
            Console.WriteLine(number);
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }

        public class Person
        {
            public int Age;
        }


    }
}
