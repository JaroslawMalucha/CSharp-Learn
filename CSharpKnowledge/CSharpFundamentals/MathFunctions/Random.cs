using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.MathFunctions
{
    class Random
    {
        public static void testRandom()
        {
            var rand = new System.Random();
            const int passwordLenght = 10;
            var buffer = new char[passwordLenght];
            for (var i = 0; i < passwordLenght; i++)
                buffer[i] = (char)('a' + rand.Next(0, 26));
            var password = new string(buffer);
            Console.WriteLine(password);


                //Console.Write((char)('a' + rand.Next(0, 26) ) );

            Console.WriteLine();
            Console.WriteLine((int) 'a');

            
        }
    }
}
