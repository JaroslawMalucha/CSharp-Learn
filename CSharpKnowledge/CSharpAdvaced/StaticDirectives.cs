using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// static directives allow to access method of class directly
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-static
using static System.Math;
using static System.Console;

namespace CSharpAdvanced
{
    class StaticDirectives
    {
        public static void test()
        {
            WriteLine(Round(2.231521, 2));
        }
    }
}
