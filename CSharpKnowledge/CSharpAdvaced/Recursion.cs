using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    class Recursion
    {
        public static void test()
        {
            FactorialNonRecursive(5);
            Factorial(5);


            string path = string.Empty;
            path = @"D:\Jarek\Projects\CSharp\Learn\Courses\Udemy_the-complete-c-sharp-developer-course";
            Console.WriteLine(path);
            DisplayFolder(path, 0 );
            DisplayFolders(path, 0);
        }

        // non-recursive factorial
        public static int FactorialNonRecursive(int n)
        {
            if (n == 0)
                return 1;
            int value = 1;
            for (int i = n; i > 0; i--)
            {
                value *= i;
                Console.WriteLine(i);
            }
            return value;
        }

        // recursive way
        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }


        public static void DisplayFolder(string path, int indent)
        {
            foreach (var folder in Directory.GetDirectories(path))
            {
                Console.WriteLine($"{new string(' ', indent)} {Path.GetFileName(folder)}");
            }
        }
        public static void DisplayFolders(string path, int indent)
        {
            foreach (var folder in Directory.GetDirectories(path))
            {
                Console.WriteLine($"{new string(' ', indent)} {Path.GetFileName(folder)}");
                DisplayFolders(folder, indent + 2);
            }
        }

    }
}
