using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    class UsingStatement
    {
        public static void test()
        {
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement
            // https://stackoverflow.com/questions/212198/what-is-the-c-sharp-using-block-and-why-should-i-use-it?answertab=votes#tab-top

            using (StreamWriter sw = new StreamWriter(@"C:\jmTEMP\faces.txt"))
            {
                sw.WriteLine(":)");
                sw.WriteLine(":(");
                sw.WriteLine(":O");
                sw.WriteLine(":]");
            }
        }
    }
}
