using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    class ConditionalsExercises
    {
        //CONDITIONALS
        public static void run()
        {
            validateOneNumber();
            MaxOfTwo();
            IsPortraitOrLandscape();
            SpeedCamera();
        }

        public static void validateOneNumber()
        {
            Console.WriteLine("Please enter a number between 1 and 10");

            int num = 0;
            try
            {
                num = int.Parse(Console.ReadLine());
            } catch
            {
                Console.WriteLine("Incorrect input...");
            }

            if (num <= 10 && num >= 1)
            {
                Console.WriteLine("Valid");
            } else
            {
                Console.WriteLine("Invalid");
            }
        }

        public static void MaxOfTwo()
        {
            Console.WriteLine("Please enter a number");
            int num = 0;
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Incorrect input...");
            }

            Console.WriteLine("Please enter a number");
            int num2 = 0;
            try
            {
                num2 = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Incorrect input...");
            }

            Console.WriteLine((num == num2) ? "Both numbers are equal" : (num > num2) ? "Max is " + num : "Max is " + num2);

        }

        public static void IsPortraitOrLandscape()
        {
            Console.WriteLine("Please enter a width");
            int num = 0;
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Incorrect input...");
            }

            Console.WriteLine("Please enter a height");
            int num2 = 0;
            try
            {
                num2 = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Incorrect input...");
            }

            Console.WriteLine((num == num2) ? "Its a suare!" : (num > num2) ? "Its a Landscape!" : "Its a Portrait!");

        }


        public static void SpeedCamera()
        {
            Console.WriteLine("Please enter the speed limit");
            int speedLimit = 0;
            try
            {
                speedLimit = int.Parse(Console.ReadLine());
            }
            catch{}

            Console.WriteLine("Please enter the speed of the Car");
            int carSpeed = 0;
            try
            {
                carSpeed = int.Parse(Console.ReadLine());
            }
            catch { }

            if (! (carSpeed > speedLimit) )
            {
                Console.WriteLine("Ok");
            }
            else
            {
                const int kmPerPoint = 5;
                int overspeeding = (carSpeed - speedLimit);
                int demeritPoints = overspeeding / kmPerPoint;
                Console.WriteLine("Car is driving {0} km/h too fast...", overspeeding);
                Console.WriteLine("{0} demerit points where incurred...", demeritPoints);
                if (demeritPoints > 12) Console.WriteLine("Drivers license suspended!");
            }




        }

    }

}
