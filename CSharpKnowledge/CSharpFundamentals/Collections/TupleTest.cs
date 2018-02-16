using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.ValueTuple;

namespace CSharpFundamentals.Collections
{
    class TupleTest
    {
        public static void test()
        {
            // Tuple
            // - a spicific number and sequence of elements (1 to 7 elements plus an 8th nested)
            // - Ordered sequence: The order of items in a tuple follows the order used at the time of its creation.
            // - Immutable: All properties are read-only tuple, i.e., once created, it cannot be changed.
            // - Fixed Size: The size is set at the time of its creation.If it was created with three items, you cannot add new items.
            // - Of heterogeneous objects: Each item has a specific and independent of the type of the other item. 
            // - con: Tuples don’t have an explicit semantic meaning, your code becomes unreadable.

            //https://www.codeproject.com/Articles/193537/C-Tuples

            // Creating
            var empInfo = new Tuple<int, string, string, DateTime, bool>(10, "Jack", "Wiliam", new DateTime(2012, 1, 1), true);
            var studentInfo = Tuple.Create(10, "Jack", "Wiliam", new DateTime(2012, 1, 1), true);



            // Nested Tuples
            var employeeInfo =
                new Tuple<string, string, string, string, string, string, string,
                Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal>>
                ("bla1", "bla2", "bla3", "bla4", "bla5", "bla6", "bla7",
                Tuple.Create(1m, 2m, 3m, 4m, 5m, 6m, 7m));

            var empInfo2 = new Tuple<string, string, string, string, string, string, string,
            Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal,
            Tuple<int, int, int, int, int>>>("", "", "", "", "", "", "",
            new Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal, Tuple<int, int, int, int, int>>
            (0m, 1m, 2m, 3m, 4m, 5m, 6m, Tuple.Create(100, 200, 300, 400, 500)));

            Console.WriteLine(empInfo2.Rest.Rest.Item5);

            // Accessing
            Console.WriteLine(empInfo.Item1);
            Console.WriteLine(empInfo.Item2);
            Console.WriteLine(empInfo.Item3);
            Console.WriteLine(empInfo.Item4.ToShortDateString());
            Console.WriteLine(empInfo.Item5);

            Console.WriteLine(studentInfo.Item1);
            Console.WriteLine(studentInfo.Item2);
            Console.WriteLine(studentInfo.Item3);
            Console.WriteLine(studentInfo.Item4.ToShortDateString());
            Console.WriteLine(studentInfo.Item5);


            Console.WriteLine(employeeInfo.Rest.Item7);


            // Value Tuple
            // - requires package "System.ValueTuple", via console [install-package "System.ValueTuple"] or via NuGet Package Manager
            // - allows naming the items
            (int id, string name) Carlos = (10, "Carlos");
            Console.WriteLine(Carlos.id);
            Console.WriteLine(Carlos.name);
            DisplayPlayerInfo(Carlos);

            var BatiGoals = (year2013: 21, year2014: 12);
            var Batistuta = (id: 14, name: "Batistuta", goals: BatiGoals);
            Console.WriteLine(Batistuta.id);
            Console.WriteLine(Batistuta.name);
            Console.WriteLine(Batistuta.goals.year2013);
            Console.WriteLine(Batistuta.goals.year2014);

            var rivaldo = GetRivaldo();

        }

        private static void DisplayPlayerInfo((int id, string name) player)
        {
            Console.WriteLine(player.id);
            Console.WriteLine(player.name);
        }

        private static (int id, string name) GetRivaldo()
        {
            return (110, "Rivaldo");
        }
    }
}
