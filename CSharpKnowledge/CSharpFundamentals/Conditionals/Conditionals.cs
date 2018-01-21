using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{

    class Conditionals
    {
        public static void testConditionals()
        {

            // IF THEN ELSE
            int hour = 10;
            if (hour > 10 && hour < 12)
                Console.WriteLine("It's morning.");
            else if (hour >= 12 && hour < 18)
                Console.WriteLine("It's afternoon.");
            else
                Console.WriteLine("It's evening.");


            bool isGoldCustomer = true;
            float price;
            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.05f;

            price = (isGoldCustomer) ? 19.95f : 29.84f;

            Console.WriteLine(price);


            //SWITCH
            var season = CSharpFundamentals.Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("{0} is Orange and Red",season);
                    break;
                case Season.Spring:
                    Console.WriteLine(season);
                    break;
                case Season.Summer:
                    Console.WriteLine(season);
                    break;
                case Season.Winter:
                    Console.WriteLine(season);
                    break;
                default:
                    Console.WriteLine("It's not a season");
                    break;
            }


            switch (season)
            {
                case Season.Autumn:
                case Season.Spring:
                    Console.WriteLine("These seasons are kindas weird.");
                    break;
                case Season.Summer:
                case Season.Winter:
                    Console.WriteLine("These seasons are very different in temperature.");
                    break;
                default:
                    Console.WriteLine("It's not a season");
                    break;

            }




        }
    }
}
