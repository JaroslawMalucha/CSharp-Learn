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
            //DateTime objects are immutable!!!
            //  that means that objects built in modification methods return new objects,
            //  instead of modifying the existing one, e.g. myDate.AddYears(1) returns new object
            // exact date and time point


            Console.WriteLine();
            Console.WriteLine("------------- DateTimeType -------------");

            // INSTANTIATION FROM VALUES
            var dateTime = new DateTime(2015, 1, 1);
            var dateTime2 = new DateTime(2015, 1, 1, 13, 0, 0);
            var dateTime3 = new DateTime(2015, 1, 1, 13, 0, 0, DateTimeKind.Local);
            var dateTime4 = DateTime.SpecifyKind(dateTime3, DateTimeKind.Utc);
            
            var now = DateTime.Now;
            var today = DateTime.Today;
            var curYear = DateTime.Now.Year;

            // INSTANTIATION FROM STRINGS
            var dateTime5 = DateTime.Parse("2015 10 10");
            string dateTimeString = "01/08/2008 14:50:50.42";
            DateTime dt = Convert.ToDateTime(dateTimeString);
            Console.WriteLine("Year: {0}, Month: {1}, Day: {2}, Hour: {3}, Minute: {4}, Second: {5}, Millisecond: {6}",
                              dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, dt.Millisecond);
            // Specify exactly how to interpret the string.  
            IFormatProvider culture = new System.Globalization.CultureInfo("fr-FR", true);

            // Alternate choice: If the string has been input by an end user, you might    
            // want to format it according to the current culture:   
             IFormatProvider culture2 = System.Threading.Thread.CurrentThread.CurrentCulture;  
            DateTime dt2 = DateTime.Parse(dateTimeString, culture, System.Globalization.DateTimeStyles.AssumeLocal);
            Console.WriteLine("Year: {0}, Month: {1}, Day: {2}, Hour: {3}, Minute: {4}, Second: {5}, Millisecond: {6}",
                              dt2.Year, dt2.Month, dt2.Day, dt2.Hour, dt2.Minute, dt2.Second, dt2.Millisecond);

            string s = "2011-03-21 13:26";
            DateTime dt3 =DateTime.ParseExact(s, "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture);

            // ACCESSING DATETIME COMPONENTS
            Console.WriteLine("Year: {0}, Month: {1}, Day: {2}, Hour: {3}, Minute: {4}, Second: {5}, Millisecond: {6}",
                              now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second, now.Millisecond);
            Console.WriteLine("Ticks: {0}, TimeOfDay: {1}, Kind: {2}, IsDaylightSavingTime: {3}, DayOfWeek: {4}, DayOfYear: {5}",
                              now.Ticks, now.TimeOfDay, now.Kind, now.IsDaylightSavingTime(), now.DayOfWeek, now.DayOfYear);
            Console.WriteLine("CompareTo: " + now.CompareTo(now.AddYears(1)));
            var strings = now.GetDateTimeFormats();

            //ADDING and SUBTRACTING DATETIME VALUES
            var nextSecond = now.AddSeconds(1);
            var nextMilliSecond = now.AddMilliseconds(1000);
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            var nextMonthNow = now.AddMonths(1);
            var nextYearNow = now.AddYears(1);

            //FORMATTING AS STRING
            // https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings
            // http://blog.stevex.net/string-formatting-in-csharp/
            Console.WriteLine("ToLongDateString:{0} , ToShortDateString:{1} , ToLongTimeString:{2} , ToShortTimeString:{3} , ",
                            now.ToLongDateString(), now.ToShortDateString(), now.ToLongTimeString(), now.ToShortTimeString());
            Console.WriteLine("ToString:{0} , ToString(\"yyyy - MM - dd HH: mm\"):{1} , string.Format(\"Date is {0:yyyy MMMM dd hh:mm:ss tt}\", now): {2}", 
                            now.ToString() , now.ToString("yyyy-MM-dd HH:mm"), string.Format("Date is {0:yyyy MMMM dd hh:mm:ss tt}", now));

            Console.WriteLine("Format as 30-09-2017 09:09:59: {0}", now.ToString("dd-MM-yyyy hh:mm:ss"));
            Console.WriteLine("Format as Friday of month September year 2017: {0}", 
                string.Format("{0:dddd} of month {0:MMMM} year {0:yyyy}", now));
            Console.WriteLine("Format as Friday of month September year 2017: {0}",
                string.Format("{0:dddd 'of month' MMMM 'year' yyyy}", now));
            Console.WriteLine("Format as:\nDay Friday\nMonth Septemder\nYear 2017 \n:\n{0}",
                string.Format("Day {0:dddd}\nMonth {0:MMMM}\nYear {0:yyyy}", now));
            Console.WriteLine();

        }

        public static void TimeSpanObject()
        {
            Console.WriteLine();
            Console.WriteLine("------------- TimeSpanObject -------------");

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

