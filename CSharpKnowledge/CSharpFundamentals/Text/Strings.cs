using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    class Strings
    {
        public static void StringsBasics()
        {
            string firstName = "Mosh";
            string laastName = "Smith";
            string name = firstName + " " + laastName;
            name = string.Format("{0} {1}", firstName, laastName);

            var numbers = new int[3] { 1, 2, 3 };
            string list = string.Join(",", numbers);
            var numbers2 = list.Split(',');
            list = "asdf";
            char firstChar = list[0];
            firstChar = 'L';        // => this creats a new string
            //list[0] = 'AASD';     // => existing strings are immutable

            // ESCAPE CHARACTERS:
            //  /n - New Line
            //  /t - Tab
            //  // - Backslash
            //  /' - Single Quotation Mark
            //  /" - Double Quatation Mark

            // VERBATIM STRINGS
            string path = "c:\\projects\folder1";
            path = @"c:\projects\folder1";
            var text = "Hi John\nLook in this dir\nC:\\folder1";
            text = @"Hi John
Look in this dir
C:\folder1";
            Console.WriteLine(text);

            // FUNCTIONS
            var myFullName = string.Format("My name is {0} {1}", firstName, laastName);
            var formattedNames = string.Join(",", new string[]{ "Jack", "John", "Maya"});
            Console.WriteLine(formattedNames);


        }
    }
}
