using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    delegate void DisplayInfo();
    delegate void DisplayInfoWithPar(int num);

    class AnonymousMethods
    {
        public static void test()
        {
            DisplayInfo normalDelegateAnonymous = delegate { Console.WriteLine("I am anonymous LOL"); };
            normalDelegateAnonymous();
            normalDelegateAnonymous();
            normalDelegateAnonymous();


            DisplayInfoWithPar parametrizedDelegateAnonymous = delegate (int x) { Console.WriteLine("I am anonymous LOL and the number is :" + x); };
            parametrizedDelegateAnonymous(4);
            parametrizedDelegateAnonymous(21);
            parametrizedDelegateAnonymous(5);

        }
    }
}
