using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    class LoopsExercise
    {
        public static void testLoops()
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise5();
        }

        //Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
        //Display the count on the console.
        public static void Exercise1()
        {
            int count = 0;
            for (int i = 1; i < 101; i++) if (i % 3 == 0) count++;
            Console.WriteLine(count);

            count = 0;
            for (int i = 3; i < 101; i += 3) count++;
            Console.WriteLine(count);
        }

        //Write a program and continuously ask the user to enter a number or "ok" to exit.
        //Calculate the sum of all the previously entered numbers and display it on the console.
        public static void Exercise2()
        {

            double sum = 0;
            while (true)
            {
                Console.WriteLine("enter a number or \"ok\" to exit");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    continue;
                else if (input == "ok")
                    break;
                else
                {
                    sum += double.Parse(input);
                }
            }
            Console.WriteLine("sum is: " + sum);
        }
        //Write a program and ask the user to enter a number.
        //Compute the factorial of the number and print it on the console.
        //For example, if the user enters 5, the program should 
        //calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
        public static void Exercise3()
        {
            Console.WriteLine("enter a number to calculate its factorial");
            var input = Console.ReadLine();
            Console.WriteLine("{0}! = {1}", input, Factorial(int.Parse(input)));
        }

        public static int Factorial(int num)
        {
            int fac = num;
            for (num -= 1; num > 0; --num) fac *= num;
            return fac;
        }

        //Write a program that picks a random number between 1 and 10. 
        //Give the user 4 chances to guess the number.
        //If the user guesses the number, display “You won"; otherwise, display “You lost". 
        //(To make sure the program is behaving correctly, 
        //    you can display the secret number on the console first.)
        public static void Exercise4()
        {
            const int chancesGiven = 4;
            var chancesLeft = chancesGiven;
            var randomizer = new System.Random();
            int rand = randomizer.Next(1, 10);
            Boolean hasWon = false;
            while (chancesLeft>0)
            {
                Console.WriteLine("Guess a number between 1 and 10");
                var input = Console.ReadLine();
                if (int.Parse(input) == rand)
                {
                    hasWon = true;
                    break;
                }

                chancesLeft--;
            }
            Console.WriteLine((hasWon)? "You won": "You lost, the number was: " + rand);
        }

        //Write a program and ask the user to enter a series of numbers separated by comma.
        //Find the maximum of the numbers and display it on the console.
        //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
        public static void Exercise5()
        {
            Console.WriteLine("enter a series of numbers separated by comma");
            var input = Console.ReadLine();
            int[] ints = Array.ConvertAll(input.Split(','),int.Parse);
            Console.WriteLine(MaxOfArray(ints));
        }

        public static int MaxOfArray(int[] ints)
        {
            int max = ints[0];
            for (int i = 1; i < ints.Length; i++)
            {
                if (ints[i] > max) max = ints[i];
            }
            return max;
        }



    }
}
