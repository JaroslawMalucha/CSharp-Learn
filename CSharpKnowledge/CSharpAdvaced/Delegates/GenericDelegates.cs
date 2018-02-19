using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Delegates
{
    public delegate T DisplayInfo<T>(T value);

    class GenericDelegates
    {
        public static void test()
        {
            DisplayInfo<int> myNumber = new DisplayInfo<int>(DisplayValue);
            Console.WriteLine(myNumber(100));

            DisplayInfo<double> myDoubleNumber = new DisplayInfo<double>(DisplayValue);
            Console.WriteLine(myDoubleNumber(3.5));

            DisplayInfo<DateTime> myDate = new DisplayInfo<DateTime>(DisplayValue);
            Console.WriteLine(myDate(new DateTime(2010, 2, 28)));



            // Func<type, type>   - a built in generic delegate with a return value
            // - here just so that you dont have to declare your own delegate every time
            // - up to 16 parameters
            // - one out parameter
            // - last parameter is the OUT parameter
            // - Func delegate type must return value

            Func<int, int, int> funcOne = AddTwoNumbers;
            Console.WriteLine(AddTwoNumbers(3, 5));
            Console.WriteLine(funcOne(3, 5));

            Func<int> funcTwo = AddTwoNumbers;
            Console.WriteLine(AddTwoNumbers());
            Console.WriteLine(funcTwo());

            // Action<type, type>   - a built in generic delegate withOUT a return value
            Action<int> actionOne = DisplayInfo;
            DisplayInfo(5);
            actionOne(5);

            Action actionTwo = DisplayInfo;
            DisplayInfo();
            actionTwo();


            // Predicate - a special case of a Func delegate where there is one input variable and output is a boolean 
            Predicate<int> condition = IsAdmin;
            condition += IsEven; // multicast => only last called func result will be used as Predicats output, all previously called funcs outputs will be ignored
            Console.WriteLine(condition(10)); // true since last is true
            Console.WriteLine(condition(8)); // true since last is true


            // Func with:
            // - normal methods
            // - anonymous methods
            // - lambda expressions

            // Func with normal methods
            Func<string, string> conv = MakeUpperCase;
            conv("normal method");

            // Func with anonymous methods
            Func<string, string> conv2 = delegate (string text) { return text.ToUpper(); };
            conv2("anonymous");

            // Func with lambda
            Func<string, string> conv3 = text => text.ToUpper();
            conv3("lambda");



            // Action with:
            // - normal methods
            // - anonymous methods
            // - lambda expressions

            // Action with normal methods
            Action<string> action = PrintText;
            action("normal method");

            // Action with anonymous methods
            Action<string> action2 = delegate (string text) { Console.WriteLine(text) ; };
            action2("anonymous");

            // Action with lambda
            Action<string> action3 = text => Console.WriteLine(text);
            action3("lambda");
        }

        public static T DisplayValue<T>(T value)
        {
            Console.WriteLine("Now we are accessing variable of type " + value.GetType().Name);
            return value;
        }

        public static int AddTwoNumbers(int x, int y) { return x + y; }

        public static int AddTwoNumbers()
        {
            int z = 0;
            int x = 5;
            int y = 2;
            z = x + y;
            return z;
        }

        public static void DisplayInfo()
        {
            Console.WriteLine("Info tralalala");
        }
        public static void DisplayInfo(int number)
        {
            Console.WriteLine($"Info with a {number} tralalala");
        }

        public static bool IsAdmin(int empNo)
        {
            return (empNo == 10);
        }

        public static bool IsEven(int num) { return (num % 2 == 0); }

        public static string MakeUpperCase(string text) { return text?.ToUpper(); }

        public static void PrintText(string text) { Console.WriteLine(text); }
    }
}
