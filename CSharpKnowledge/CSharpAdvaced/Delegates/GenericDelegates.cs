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
        }

        public static T DisplayValue<T>(T value)
        {
            Console.WriteLine("Now we are accessing variable of type " + value.GetType().Name);
            return value;
        }
    }
}
