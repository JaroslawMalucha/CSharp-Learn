using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System  //this will add the Extension Methods class to System and will ease access to it
{
    static class StringExtenions
    {
        // DEFINITION
        // extension methods allow to extend functionality of the given class
        //   without changing the source code of that class or using inheritance
        //   e.g. you cannot inherit from String as it is a sealed class 
        //      but you can use Extension Methods to extend its functionality

        // TO CREATE AN EXTENSION METHOD:
        // - class must be static, preferably public 
        // - methods must be public static
        // - methods must contain "this Type varName" as the first argument
        // - Extenions class must be within the scop, duhh
        // - to easily add Extension class to the global Scope just use the Systme Namespace as containing Namespace

        // WARNING !!!
        // Extension Methods from Microsoft are not guaranteed to ...
        //  ...function exactly the same in each .NET version
        //  => the could be updated and behave differently


        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("numberOfWords must be greater of equal to zero.");

            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords))+"..."; // Take is actually an EXtension Method provided my Microsoft later on in the .NET development
        }
    }
}
