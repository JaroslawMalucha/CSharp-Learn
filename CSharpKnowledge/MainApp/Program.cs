using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CSharpFundamentals.Program.Main(null);
            CSharpIntermediate.Program.Main(null);
            CSharpAdvanced.Program.Main(null);


            Console.WriteLine();
            Console.WriteLine();

            // BY DESIGN CONSOLE APPLICATIONS CLOSE WHEN FINISHED RUNNING IN THE DEBUGGING MODE
            // USE THIS TO SIMULATE STANDARD BEHAVIOR
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("Press any key to continue . . .");
                Console.ReadLine();
            }
            // OR THIS
#if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
#endif
        }
    }
}
