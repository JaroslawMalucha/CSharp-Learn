using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    class ExpressionBodiedMembers
    {
        public static void test()
        {
            Console.WriteLine(AddTwoNumbersFaster(3,72));
            SayHi();

        }

        public static void SayHi() => Console.WriteLine("Hi Marduk");

        public static int AddTwoNumbersFaster(int x, int y) => x + y;

        public static int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }
    }


    class Animals
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private int name;

        public int Name
        {
            get => name;
            set => name = value;
        }

        //public Animals()
        //{
        //    Console.WriteLine("A new animal was created");
        //}
        public Animals() => Console.WriteLine("A new animal was created");

    }

}
