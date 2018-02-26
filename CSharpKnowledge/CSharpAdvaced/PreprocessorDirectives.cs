


#define underDev //defines a symbol

//for this file only
#pragma warning disable 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    class PreprocessorDirectives
    {
        public static void test()
        {
            // preprocessor directives give compiler instructions before actual compiling starts
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/preprocessor-directives/
            int c;
            #region my comment for this region - this is a collapsable code region
            //your code goes here
            #endregion

#if (underDev)
            Console.WriteLine("Under construction");

            //warning will show up in compilation Output window and in error list window
#warning this app is not complete and not ready to be published
            //error will show up in compilation Output window and in error list window
//#error this app is not finished omg remove this error
#else
            global::System.Console.WriteLine("done");
#endif
        }


    }
}
