using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    class Lists
    {
        static System.Collections.Generic.List<int> numbers;

        public static void testList()
        {
            //ListBasics();
            Exercises();
        }
        public static void Exercises()
        {
            //Exercise1();   
            //Exercise2()
            //Exercise3();
            Exercise4();
            //Exercise5();
        }
        //When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
        //    If no one likes your post, it doesn't display anything.
        //    If only one person likes your post, it displays: [Friend's Name] likes your post.
        //    If two people like your post, it displays: [Friend 1]
        //        and[Friend 2] like your post.
        //If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.

        //Write a program and continuously ask the user to enter different names, 
        //until the user presses Enter (without supplying a name). 
        //Depending on the number of names provided, display a message based on the above pattern.
        public static void Exercise1()
        {
            var likes = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter a name or press Enter to finnish:");
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    break;
                likes.Add(input);
                if (likes.Count == 1)
                    Console.WriteLine(likes[0] + " likes your post");
                else if (likes.Count == 2)
                    Console.WriteLine(likes[0] + " and " + likes[1] + " like your post");
                else
                    Console.WriteLine(likes[0] + ", " + likes[1] + " " + (likes.Count - 2) + " other like your post");
            }

        }


        //Write a program and ask the user to enter their name.
        //Use an array to reverse the name and then store the result in a new string. 
        //Display the reversed name on the console.
        public static void Exercise2()
        {
            Console.WriteLine("Enter a name or press Enter to finnish:");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                return;
            //Array.Reverse(input);
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            string name = new string(arr);
            Console.WriteLine(name);

        }

        //Write a program and ask the user to enter 5 numbers.
        //If a number has been previously entered, 
        //display an error message and ask the user to re-try. 
        //Once the user successfully enters 5 unique numbers, 
        //sort them and display the result on the console.
        public static void Exercise3()
        {
            var nums = new List<int>();
            while (nums.Count < 5)
            {
                Console.WriteLine("Please enter a number:");
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    continue;

                int num = int.Parse(input);
                if (nums.Contains(num))
                {
                    Console.WriteLine("You already entered this number try again");
                    continue;
                }
                else
                {
                    nums.Add(num);
                }
            }
            nums.Sort();
            PrintList(nums);
        }

        //Write a program and ask the user to continuously enter a number or type "Quit" to exit.
        //The list of numbers may include duplicates. 
        //Display the unique numbers that the user has entered.
        public static void Exercise4()
        {
            var nums = new List<int>();
            var unique = new List<int>();
            while (true)
            {
                Console.WriteLine("Please enter a number or Type 'Quit' to exit:");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;
                nums.Add(int.Parse(input));
            }
            unique = nums.Distinct().ToList();
            Console.WriteLine("Printing unique values");
            PrintList(unique);
            Console.WriteLine("Last number is: " + unique.Last());
            
        }

        //Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10). 
        //If the list is empty or includes less than 5 numbers, 
        //display "Invalid List" and ask the user to re-try;
        //otherwise, display the 3 smallest numbers in the list.
        public static void Exercise5()
        {
            while (true)
            {
                Console.WriteLine("supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10), more then 5");
                var input = Console.ReadLine();
                var nums = Array.ConvertAll(input.Split(','), int.Parse);
                if(nums.Count()<5)
                {
                    Console.WriteLine("Invalid List, Please Try again...");
                    continue;
                }
                else
                {
                    Array.Sort(nums);
                    Console.WriteLine("Those are the smallest numbers: {0}, {1}, {2}", nums[0], nums[1], nums[2]);
                    break;

                }

            }


        }


        public static void ListBasics()
        {
            // System.Collections.Generic.List<T>
            //  is a .NET lib Collection
            //  it cannot be modified inside a foreach loop

            numbers = new List<int>();
            numbers = new List<int> { 1, 2, 11, 4, 4, 6, 1, 1, 1 };
            Print();

            // Add()
            numbers.Add(1);
            Print();

            // AddRange() - array or list or...
            numbers.AddRange(new int[3] { 5, 5, 6 });
            Print();

            // IndexOf()
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1,1));

            // LastIndexOf()
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Index of 1: " + numbers.LastIndexOf(1));

            // Remove()
            Console.WriteLine("Removing 1...");
            //numbers.Remove(1);
            //Print();
            RemoveAllItemOccurences2(numbers, 1);
            Print();

            // RemoveAt()
            Console.WriteLine("Removing at 3...");
            numbers.RemoveAt(2);
            Print();

            // Contains()
            Console.WriteLine("Does contain 1: " + numbers.Contains(1));

            // Count()
            Console.WriteLine("Count: " + numbers.Count());

            // Clear()
            Console.WriteLine("Clearing...");
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count());
        }

        public static void Print()
        {
            Console.WriteLine("NEW PRINT CALL...");
            PrintList(numbers);
        }

        public static void PrintList(List<int> list)
        {
            foreach (var e in list)
                Console.WriteLine(e);
        }

        public static void RemoveAllItemOccurences1(List<int> nums, int num)
        {
            for (var i = 0; i < numbers.Count; )
            {
                if (nums[i] == num)
                {
                    nums.Remove(nums[i]);
                }
                else
                {
                    i++;
                }
            }
        }
        public static void RemoveAllItemOccurences2(List<int> nums, int num)
        {
            while (nums.Contains(num))
            {
                nums.Remove(num);
            }
        }

    }
}
