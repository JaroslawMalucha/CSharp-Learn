using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicSquare;

namespace SimpleConsoleApps
{
    class SimpleApps
    {
        public static void Run()
        {
            //MilesToFeet();
            //SchoolInfo();
            //Doyle32Methods();
            //pHLevel51();
            //_6_1_RandomNumbers();
            //Doyle_6_2_InputValidation();
            //Doyle_6_7_MultiplicationTable();
            //Doyle_7_2_Sales();
            //Doyle_7_9_Chart();
            //_8_1_TwoDimensionalArrays();
            //TestFactorial();
            //TestFizzBuzz();
            TestIsMagicSquare();
        }

        private static void MilesToFeet()
        {
            float miles = 4.5f;
            const int MILES_RATIO = 5280;
            const int INCHES_RATIO = 63360;

            Console.WriteLine("{0:F2} miles = {1} feet", miles, miles * MILES_RATIO); //F2 means float
            Console.WriteLine("{0:F2} miles = {1} inches", miles, miles * INCHES_RATIO);
        }

        /*
Write an application that includes two additional methods in addition to the
Main( ) method. One method should return a string consisting of four or
five lines of information about your school. The other method should return
a string consisting of asterisks. First call the method that returns the string of
asterisks. Call the method that returns the asterisk a second time after you
invoke the method that displays the information about your school. Items
you might include are the name of your school, number of students enrolled,
and school colors. Include appropriate labels. The display should be aesthetically
pleasing so include enough asterisks to surround your listing.
*/
        static void SchoolInfo()
        {
            string asterix = Asterix();
            Console.WriteLine(asterix);
            Console.WriteLine(SchoolInfoPrint());
            Console.WriteLine(Asterix());
        }

        static string Asterix()
        {
            //return "***************************************************";
            /*
            string asterix = "*";
            for (int i = 0; i < 50; i++)
            {
              asterix += "*";
            }
            return asterix;
            */

            return new String('*', 50);
        }

        static string SchoolInfoPrint()
        {
            string schoolName = "City University of Seattle";
            string schoolCountry = "Slovakia";
            int schoolCost = 15000;
            int numOfStudents = 1000;

            string schoolInfo = String.Format("School Name:        {0}\n" +  //\n is new line
                                              "School Country:     {1}\n" +
                                              "School Cost:        {2:C2}\n" + //
                                              "Students Attending: {3}",
                                              schoolName, schoolCountry, schoolCost, numOfStudents);
            return schoolInfo;
        }

        /*
Design a message display application. Allow users to enter their name and
favorite saying in a single method that gets invoked two times. First call the
method asking for the person’s name. Send a string argument indicating what
value should be entered. Invoke the method a second time to retrieve the
favorite saying. Return the string values back to the Main( ) method. Call
another method, sending the name and saying. From that method, display the
message showing the person’s name and their saying surrounded by rows of
greater than/less than symbols(<><><>).
*/
        static void Doyle32Methods()
        {
            string name = Message("name");
            string phrase = Message("favorite saying");

            DisplayOutput(name, phrase);
        }
        public static string Message(string msg)
        {
            Console.WriteLine("Please enter your {0}: ", msg);
            return Console.ReadLine();
        }

        public static void DisplayOutput(string name, string phrase)
        {
            Console.WriteLine("\n<><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("Your name is {0}", name);
            Console.WriteLine("Your favorite saying is {0}", phrase);
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><>\n");
        }





        /*
Write an application that will enable you to display an aquarium’s pH level. The
pH is a measure of the aquarium water’s alkalinity and is typically given on a 0-14
scale. For most freshwater fish tanks, 7 is neutral. Tanks with a pH lower than 7
are considered acidic. Tanks with a pH higher than 7 are alkaline. Allow the user
to input the pH level number. Display a message indicating the health (i.e.,
acidic, neutral, or alkaline) of the aquarium. 
 */
        static void pHLevel51()
        {
            double pH;
            Console.WriteLine("Please enter the pH level: ");
            if (double.TryParse(Console.ReadLine(), out pH) == false || pH < 0 || pH > 14)
                Console.WriteLine("Invalid Input");
            else if (pH < 7)
                Console.WriteLine("pH is Acidic");
            else if (pH > 7)
                Console.WriteLine("pH is Alkaline");
            else
                Console.WriteLine("pH is neutral");
        }

        /*
        Write a program that generates 1000 random numbers between 0 and 100000.
        Display the number of odd values generated as well as the smallest and the largest
        of values. Output should be displayed in a Windows message box.
         */

        static void _6_1_RandomNumbers()
        {
            int max = 0;
            int min = 100000;
            int randomNumber;
            int counter = 0;

            Random rand = new Random();

            for (int i = 0; i < 1000; i++)
            {
                randomNumber = rand.Next(0, 100001);
                if (randomNumber % 2 != 0)
                {
                    counter++;
                    max = (randomNumber > max) ? randomNumber : max;
                    min = (randomNumber < min) ? randomNumber : min;
                }
            }

            MessageBox.Show("Max Number: " + max + "\n" +
                            "Min Number: " + min + "\n" +
                            "Total Numbers Generated: " + counter, "Final Results", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        /*
        Create an application that contains a loop to be used for input validation.
        Valid entries are positive integers less than 100. Test your program with values
        both less than and greater than the acceptable range as well as non-numeric
        data. When the user is finished inputting data, display the number of valid and
        invalid entries entered. 
        */

        static void Doyle_6_2_InputValidation()
        {
            int counterGood = 0;
            int counterBad = 0;
            string input = "";

            do
            {
                Console.WriteLine("Please enter a number 0 - 99, or type Q to quit");
                input = Console.ReadLine();
                if (!input.ToUpper().Equals("Q"))
                {
                    int number = 0;
                    if (int.TryParse(input, out number))
                    {
                        if (number >= 0 && number <= 99)
                            counterGood++;
                        else
                            counterBad++;
                    }
                    else
                        counterBad++;
                }
            }
            while (!input.ToUpper().Equals("Q"));

            Console.WriteLine("Valid numbers entered: " + counterGood);
            Console.WriteLine("Invalid numbers entered: " + counterBad);
        }

        /*
        Write a program that produces a multiplication table with 25 rows of computations.
        Allow the user to input the first and last base values for the
        multiplication table. Display a column in the table beginning with the first
        base inputted value. The last column should be the ending base value entered.
        The first row should be for 1 times the beginning base, 1 times the (beginning
        base value + 1), through 1 times the ending base value. The last row should
        be for 25 times the beginning base, 25 times the (beginning base value + 1),
        through 25 times the ending base value. Base values can range from 2 through
        8. Display an error message if an invalid base is entered. Display an aesthetically
        formatted multiplication table. 
        */
        static void Doyle_6_7_MultiplicationTable( )
        {
            int beginningValue;
            int endValue;

            do
            {
                Console.Write("Please enter beginning base value: ");
                beginningValue = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter ending base value: ");
                endValue = Convert.ToInt32(Console.ReadLine());

                if (beginningValue < 2 || endValue > 8)
                    Console.WriteLine("Invalid Input");
            } while (beginningValue < 2 || endValue > 8);

            Console.WriteLine("\n");

            //headers
            for (int i = beginningValue - 1; i <= endValue; i++)
            {
                if (i == beginningValue - 1)
                    Console.Write(String.Format("{0,6}", "n"));
                else
                    Console.Write(String.Format("{0,6}", i));
            }

            Console.WriteLine("\n");

            for (int i = 1; i <= 25; i++) //rows
            {
                Console.Write(String.Format("{0,6}", i));
                for (int b = beginningValue; b <= endValue; b++)// collumns
                {
                    string output = String.Format("{0,6}", i * b); // ,6 means the constant width
                    Console.Write(output);
                }
                Console.WriteLine("");
            }
        }




        /*
        The Ion Realty Sales Corporation would like to have a listing of their sales over
        the past few months. Write a program that accepts any number of monthly sales
        amounts. Display the total of the values. Display a report showing each original
        value entered and the percentage that value contributes to the total. You may
        prompt the user for the number of values to be inputted. 
        */
        static void Doyle_7_2_Sales()
        {
            int numberOfSales = 0;
            double[] sales;

            Console.Write("Please enter number of sales ");
            numberOfSales = Convert.ToInt32(Console.ReadLine());

            sales = new double[numberOfSales];

            for (int i = 0; i < numberOfSales; i++)
            {
                Console.Write("Please enter sale #{0}: ", i + 1);
                sales[i] = Convert.ToDouble(Console.ReadLine());
            }

            double sum = sales.Sum();
            for (int i = 0; i < numberOfSales; i++)
            {
                double contribution = sales[i] / sum;
                Console.WriteLine("Sale # {0} was {1:C2} and contributed {2:P2}", i + 1, sales[i], contribution);
            }
            Console.WriteLine("Total sum of sales is {0:C2}", sum);
        }


        /*
Write a program that uses array and that allows any number of values between 0 and 10 to be
entered. When the user stops entering values, display a frequency distribution
bar chart. Use asterisks to show the number of times each value was entered. If a
given number is not entered, no asterisks should appear on that line. Your
application should display error messages if a value outside the acceptable range
is entered or if a non-numeric character is entered. 
*/
        static void Doyle_7_9_Chart( )
        {
            bool validInput = false;
            string input;
            int result;
            bool stopInput = false;
            string allInput = "";

            while (!stopInput)
            {
                do
                {
                    validInput = false;
                    Console.WriteLine("Please enter a number between 0 and 10 OR enter Q to exit program");
                    input = Console.ReadLine();

                    if (int.TryParse(input, out result))
                    {
                        if (result > 0 && result < 10)
                        {
                            validInput = true;
                            allInput += input + ",";
                        }
                    }

                    if (input.ToUpper().Equals("Q"))
                    {
                        validInput = true;
                        stopInput = true;
                    }

                    if (!validInput)
                        Console.WriteLine("Invalid Input. The value won't be counted");
                } while (!validInput);
            }

            string[] numbers = allInput.Split(',');

            for (int i = 1; i < 10; i++)
            {
                Console.Write("\n" + i + "   ");
                for (int c = 0; c < numbers.Length - 1; c++)
                {
                    if (Convert.ToInt32(numbers[c]) == i)
                        Console.Write("*");
                }
            }

            Console.WriteLine("\n");

        }


        /*
        Write an application that creates and returns a one-dimensional array containing
        all the elements in the two-dimensional array. Store the values in a row major
        format. For testing purposes, you may do a compile-time initialization of a 12 x 5
        two-dimensional array. Display both the two-dimensional and the one dimensional
        array. Be sure the values in the array are number aligned.
        */
        static void _8_1_TwoDimensionalArrays()
        {
            int[,] twoDimensionalArray = new int[12, 5];
            int[] oneDimensionalArray = new int[twoDimensionalArray.Length];
            Random rand = new Random();
            int counter = 0;

            for (int r = 0; r < 12; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    twoDimensionalArray[r, c] = rand.Next(0, 101);
                    oneDimensionalArray[counter] = twoDimensionalArray[r, c];
                    counter++;
                }
            }

            Console.WriteLine("Two Dimensional Array...");
            for (int r = 0; r < 12; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(twoDimensionalArray[r, c] + " ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("One Dimensional Array...");
            for (int i = 0; i < oneDimensionalArray.Length; i++)
            {
                if (i % 5 == 0)
                    Console.Write("\n");

                Console.Write(oneDimensionalArray[i] + " ");
            }
            Console.Write("\n");
        }






        public static void TestFactorial()
        {
            Console.WriteLine(Factorial(5));
            Console.WriteLine(Factorial2(5));
            Console.WriteLine(Factorial3(5));
            Console.WriteLine(Factorial4_recursive(5));

            Console.WriteLine(Factorial(1));
            Console.WriteLine(Factorial2(1));
            Console.WriteLine(Factorial3(1));
            Console.WriteLine(Factorial4_recursive(1));

            Console.WriteLine(Factorial(0));
            Console.WriteLine(Factorial2(0));
            Console.WriteLine(Factorial3(0));
            Console.WriteLine(Factorial4_recursive(0));
        }




        public static int Factorial(int n)
        {
            // from last with 1
            var factorial = 1;
            for (int i = n; i >= 1; i--)
            {
                factorial *= i;
            }
            return factorial;
        }

        public static int Factorial2(int n)
        {
            // from 1 with n -> invalid for n=zero
            var factorial = n;
            for (int i = 1; i < n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        public static int Factorial3(int n)
        {
            // from 1
            var factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        public static int Factorial4_recursive(int n)
        {
            // from 1
            if (n <= 0)
                return 1;
            return Factorial4_recursive(n-1) * n;
        }


        public static void TestFizzBuzz()
        {
            //FizzBuzz1(100);
            FizzBuzz2_recursive(100);
        }


        public static void FizzBuzz1(int n)
        {
            for (int i = 1; i <=n; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                    Console.WriteLine("Fizz Buzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }

        public static void FizzBuzz2_recursive(int n)
        {
            if (n <= 0)
                return;
            
                if ((n % 3 == 0) && (n % 5 == 0))
                    Console.WriteLine("Fizz Buzz");
                else if (n % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (n % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(n);

            FizzBuzz2_recursive(--n);
        }

        public static void TestIsMagicSquare()
        {
            MagicSquare.MagicSquare.Run();
        }

        











































































































































































































































































    }
}
