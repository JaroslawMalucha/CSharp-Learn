using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpAdvanced
{
    public class ExceptionHandling
    {
        public static void testExceptionHandling()
        {
            try
            {
                var calc = new Calculator();
                var res = calc.Divide(5, 0);
                
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by zero");
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("You cannot perorm this arithmetic operation");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ups");
            }

            StreamReader sR = null;
            try
            {
                 sR = new StreamReader(@"C:\file.zip");
                var content = sR.ReadToEnd();
                throw new Exception("Oops");
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry unexpected error occured");
            }
            finally
            {
                //every class that manages resources should implement IDisposable interface
                if (sR != null)
                    sR.Dispose();
            }

            try
            {
                using (var sR2 = new StreamReader(@"C:\file.zip"))
                {
                    //finally block becomes obsolete and object is disposed automatically
                    var content = sR.ReadToEnd();
                }
                throw new Exception("Oops");
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry unexpected error occured");
            }


            try
            {
                var api = new YTapi();
                var videos = api.GetVideos("mosh");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        class YTapi
        {
            internal List<string> GetVideos(string user)
            {
                try
                {
                    // do stuff
                    throw new Exception("Oops some low level YT exception");//just for simulation
                }
                catch (Exception ex)
                {
                    //log
                    throw new YTexception("Could not fetch the videos from YouTube", ex);
                }

                return new List<string>();
            }
        }

        class YTexception : System.Exception
        {
            public YTexception(string message, Exception innerException)
                : base(message, innerException)
            {
            }
        }

        public class Calculator
        {
            public static void testCalulator()
            {
                Console.WriteLine(new Calculator().Add(1, 2, 3, 4, 5));
                Console.WriteLine(new Calculator().Add(new int[] { 1, 1, 1, 1, 1 }));
            }


            public int Add(int a, int b)
            {
                return a + b;
            }
            public int Add(params int[] numbers)
            {
                int sum = 0;
                foreach (int num in numbers)
                    sum += num;
                return sum;
            }

            public int Divide(int a, int b)
            {
                return a / b;
            }

        }

    }
}
