using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    class DatesAndTime
    {

        public static void testDates()
        {
            DateTimeType();
            TimeSpanObject();



        }

        public static void DateTimeType()
        {
            //DateTime objects are ummutable!!!
            //  that means that objects built in modification methods return new objects,
            //  instead of modifying the existing one, e.g. myDate.AddYears(1) returns new object
            // exact date and time point
            var dateTime = new DateTime(2015,1,1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            var curYear = DateTime.Now.Year;
            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
        }

        public static void TimeSpanObject()
        {
            // a lenght of time

            //Creating
            var timeSpan = new TimeSpan(hours: 1, minutes: 2, seconds: 3);
            var timeSpan1 = new TimeSpan(hours: 1, minutes: 0, seconds: 0);
            var timeSpan2 = TimeSpan.FromHours(1); //same as above

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start; //TimeSpan object
            Console.WriteLine(duration);

            // Properties

            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            // Add
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // ToString
            Console.WriteLine("ToString: " + timeSpan.ToString()); //unneeded here sincce WriteLine runs it by default on any object
            // Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));

        }

    }

}

