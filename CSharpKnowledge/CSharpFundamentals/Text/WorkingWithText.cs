using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    class WorkingWithText
    {
        public static void testStrings()
        {
            StringBasics();
            //StringBuilderBasics();
            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            //Exercise5();
        }


        public static void StringBasics ()
        {
            //String objects are IMMUTABLE!!!
            //  that means that objects built in modification methods return new objects,
            //  instead of modifying the existing one, e.g. my String.Trim() returns new object

            // all strings are essentially a char array inside

            // STRING CREATION
            // empty
            string emptyStr = string.Empty;
            emptyStr = "";
            Console.WriteLine("".Equals(string.Empty));

            // from literals
            string firstName = "Mosh";
            string lastName = "Smith";
            // from other strings
            string name = firstName + " " + lastName;
            name = string.Format("{0} {1}", firstName, lastName);
            // from using join
            var numbers = new int[3] { 1, 2, 3 };
            string list = string.Join(",", numbers);
            var numbers2 = list.Split(',');
            list = "asdf";
            // from accessing via char index in a string
            char firstChar = list[0];
            firstChar = 'L';        // => this creates a new string
            //list[0] = 'AASD';     // => existing strings are immutable

            // from char array
            char[] firstNameChars = firstName.ToCharArray();
            firstName = new string(firstNameChars);

            // ESCAPE SEQUENCES/CHARACTERS:
            //  \n - New Line
            //  \t - Tab
            //  \\ - Backslash
            //  \' - Single Quotation Mark
            //  \" - Double Quatation Mark
            //  \a - will make a sound !!! :D

            // VERBATIM STRINGS - ignore escape charackters and allow strings to be multiline in source code
            string path = "c:\\projects\folder1";
            path = @"c:\projects\folder1";
            var text = "Hi John\nLook in this dir\nC:\\folder1";
            text = @"Hi John
Look in this dir
C:\folder1";
            Console.WriteLine(text);


            var fullName = "Jarek   Malucha   ";

            //// IMMUTABILITY
            //fullName[0] = "N"; // IMMUTABLE !!! so will not compile
            fullName.ToUpper(); // IMMUTABLE !!! will compile but just outputs a new string object

            //// FORMATTING
            //https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
            // ToUpper
            Console.WriteLine("ToUpper: " + fullName.ToUpper());
            // ToLower
            Console.WriteLine("ToLower: " + fullName.ToLower());
            // Trim
            fullName.Trim();
            Console.WriteLine("'" + fullName + "'"); //shows the immutability
            Console.WriteLine("Trim: '{0}'", fullName.Trim()); //shows the immutability
            // Format - usefull for numebrs, dates, etc.
            // check out WorkingWithDates to learn more
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            // DIRECT INSERTION OF VARIABLES - STRING INTERPOLATION
            Console.WriteLine($"my name is: {fullName} :)");


            //// SEARCH and ACCESS
            // LastIndexOf
            fullName = fullName.Trim();
            var lindex = fullName.LastIndexOf(' ');
            // IndexOf
            var index = fullName.IndexOf(' ');
            int index2 = (lindex > index && index < fullName.Length) ? lindex: index;
            // Substring
            firstName = fullName.Substring(0,index); // like mid() in vba
            lastName = fullName.Substring(index2 + 1);
            Console.WriteLine("FirstName: '{0}'", firstName);
            Console.WriteLine("LastName: '{0}'", lastName);
            // access via char index
            char letter = fullName[4];
            string phrase = fullName[4].ToString();

            //// OTHER
            // Replace
            fullName = fullName.Replace("Jarek", "Jaroslaw");
            fullName = fullName.Replace("Malucha", "Małucha");
            Console.WriteLine("FullName: '{0}'", fullName);
            // Remove
            var ii = fullName.LastIndexOf("ł");
            var fullName2 = fullName.Remove(ii,1);
            // Insert
            var fullName3 = fullName2.Insert(ii, "ł");
            Console.WriteLine(fullName3);
            // NullChecking
            if (String.IsNullOrWhiteSpace(" ")) //checks for Null, Empty String, HasOnlyWhiteSpace
                Console.WriteLine("Invalid");

            // Split 
            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: '{0}'", names[0]);
            Console.WriteLine("LastName: '{0}'", names[1]); //see that we had multiple spaces in between the names s its empty
            // Join
            fullName = names.ToString(); // will just output type of the object
            Console.WriteLine(fullName);
            fullName = String.Join(" ", names);
            Console.WriteLine(fullName);
            var formattedNames = string.Join(",", new string[] { "Jack", "John", "Maya" });
            Console.WriteLine(formattedNames);
            // Length
            Console.WriteLine(fullName.Length);



            //// CONVERSION
            //Both Convert And Parse will throw an exception if String is EmptyString or WhiteSpace
            //Convert outputs a default for numbers=>0 if string is null 
            //Parse throws an exception if string is null
            //

            // Strings To Numbers
            var str = "123";
            var age = Convert.ToByte(str); // nobody can be older theen sth like 130 years so byte is ok
            // Numbers To String
            float price = 29.95f;
            Console.WriteLine(price.ToString(format: "C"));
            Console.WriteLine(price.ToString(format: "C0"));
            // Parsing
            try { age = Byte.Parse("  "); } catch { Console.WriteLine("Could not Parse an empty String or WhiteSpace or null"); }
            try { age = Convert.ToByte("  "); } catch { Console.WriteLine("Could not Convert an empty String or WhiteSpace"); }
            Console.WriteLine("Successfully Converted a null string to {0}", Convert.ToInt32(null));

            // content type checking - TryParse
            Console.WriteLine("Testing [Type].TryParse() for string content type checking");
            var n1 = "1234567890";
            var n2 = "1,234,567,890";
            var n3 = "1234567890.000012";
            var n4 = "1,234,567,890.000012";
            int i; double d;
            Console.WriteLine(Int32.TryParse(n1, out i) );
            Console.WriteLine(Int32.TryParse(n2, out i) ); //notice that this does not recognise the number as int
            Console.WriteLine(Double.TryParse(n3, out d));
            Console.WriteLine(Double.TryParse(n4, out d));


            // SUMMARISE TEXT
            var sentence = "I am trying to check if a string contains a numeric value, if it doesnt return to a label if it does then I would like to show the main window. How can this be done?";
            Console.WriteLine(sentence);
            Console.WriteLine("Summary: " + StringUtility.SummariseText(sentence, 40));
        }

        public static void StringBuilderBasics()
        {
            //Defined in System.Text
            // a MUTABLE string!
            // easy and fast for .NET to create and manipulate strings!
            // unlike String class its not optimized for Searching!

            var sb = new StringBuilder("Hello World");

            //// MUTABLE
            var mString = new StringBuilder("Hello World");
            mString[0] = 'N';
            
            // APPEND..., REPLACE, REMOVE, INSERT
            sb.Append('-', 10);
            sb.AppendLine();
            sb.Append("Header");
            sb.AppendLine();
            sb.Append('-', 10);
            sb.Replace('-', '+');
            sb.Remove(0, 10);
            sb.Insert(0, new string('-', 10));
            //ACCESSING
            Console.WriteLine(sb.ToString());
            Console.WriteLine("Frist char: " + sb[0]);

            // CHAINING
            var sb2 = new StringBuilder("Hello World").Append('-', 10).AppendLine().Append("Header")
                .AppendLine().Append('-', 10).Replace('-', '+').Remove(0, 10).Insert(0, new string('-', 10));
            Console.WriteLine(sb2);

            Console.WriteLine(sb==sb2);
            Console.WriteLine(sb.Equals(sb2));
        }

        //Write a program and ask the user to enter a few numbers separated by a hyphen.
        //Work out if the numbers are consecutive. 
        //For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive";
        //otherwise, display "Not Consecutive".
        public static void Exercise1()
        {
            
            while (true)
            {
                Console.WriteLine("APP: CHECK FOR INCREMENTATION PATTERN...");
                Console.WriteLine("Enter a few numbers separated with a semicolon... or press Enter to skip...");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    return;
                 
                bool isPattern = IsNumericPattern(ConvertStringArrayToIntArray(input.Split(';'))
                                                , out int? difPattern);
                if (isPattern)
                    Console.WriteLine("Pattern is Consecutive, with iteration value: " + difPattern);
                else
                    Console.WriteLine("Pattern is NOT Consecutive");
            }
        }
        
        //Write a program and ask the user to enter a few numbers separated by a hyphen.
        //If the user simply presses Enter, without supplying an input, exit immediately
        //; otherwise, check to see if there are duplicates.
        //If so, display "Duplicate" on the console.
        public static void Exercise2()
        {
            while (true)
            {
                Console.WriteLine("APP: CHECK FOR DUPLICATE NUMBERS...");
                Console.WriteLine("Enter a few numbers separated with a semicolon... or press Enter to skip...");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    return;

                if (HasDuplicates(  ConvertStringArrayToIntArray( input.Split(';')),out List<int> duplicates ))
                {
                    Console.WriteLine("...Has Duplicates");
                    PrintCollection(duplicates);
                    Console.WriteLine(String.Join(";", duplicates) );
                }
                else
                {
                    Console.WriteLine("...No Duplicates");
                }

                
            }
        }

        //Write a program and ask the user to enter a time value in the 24-hour time format(e.g. 19:00). 
        //A valid time should be between 00:00 and 23:59. 
        //If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
        //If the user doesn't provide any values, consider it as invalid time.
        public static void Exercise3()
        {
            while (true)
            {
                Console.WriteLine("APP: VALIDATE TIME STRING FORMAT...");
                Console.Write("Enter time value as text...");
                Console.WriteLine(" or press Enter to skip...");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    return;

                Console.WriteLine((IsValidTimeStringFormat(input)) ? "Ok" : "Invalid Time, Valid format is from 00:00 to 23:59");
            }
        }

        //Write a program and ask the user to enter a few words separated by a space.
        //Use the words to create a variable name with PascalCase.
        //For example, if the user types: "number of students", display "NumberOfStudents". 
        //Make sure that the program is not dependent on the input.
        //So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents". 
        public static void Exercise4()
        {
            while (true)
            {
                Console.WriteLine("APP: CONVERT TO PascalCase FORMAT...");
                Console.Write("Enter some words...");
                Console.WriteLine(" or press Enter to skip...");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    return;

                Console.WriteLine(ConvertToPascalCase(input));
            }
        }

        //Write a program and ask the user to enter an English word.
        //Count the number of vowels (a, e, o, u, i) in the word. 
        //So, if the user enters "inadequate", the program should display 6 on the console.
        public static void Exercise5()
        {
            while (true)
            {
                Console.WriteLine("APP: COUNT VAWELS...");
                Console.Write("Enter some words...");
                Console.WriteLine(" or press Enter to skip...");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    return;

                Console.WriteLine(CountVowels(input));
            }
        }

        public static int CountVowels(string text)
        {
            var count = 0;
            foreach(char c in text)
                if ("aeoui".Contains(c))
                    count++;
            return count;
        }

        public static bool HasDuplicates(int[] items)
        {
            var duplicates = new List<int>();
            return HasDuplicates(items, ref duplicates, false);
        }
        public static bool HasDuplicates(int[] items, out List<int> duplicates)
        {
            duplicates = null;
            return HasDuplicates(items, ref duplicates, true);
        }
        private static bool HasDuplicates(int[] items, ref List<int> duplicates, bool returnDuplicates)
        {
            duplicates = null;
            var uniqueVals = new List<int>();
            foreach (int item in items)
            {
                if (uniqueVals.Contains(item))
                {
                    if (returnDuplicates)
                    {
                        if (duplicates == null)
                            duplicates = new List<int>();
                        if (!duplicates.Contains(item))
                            duplicates.Add(item);
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    uniqueVals.Add(item);
                }
            }
            if (returnDuplicates)
            {
                return duplicates != null;
            }
            else
            {
                return false;
            }
        }

        public static void PrintCollection<T>(IEnumerable<T> list)
        {
            foreach(var item in list)
                Console.WriteLine(item);
        }
        

        public static bool IsValidTimeStringFormat(string timeAsText )
        {
            try
            {
                if (TimeSpan.Parse(timeAsText).TotalHours <= 24)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }

        }
        

        public static int[] ConvertStringArrayToIntArray(string[] strs)
        {
            if (strs == null)
                return null;
            int[] ints = new int[strs.Length];
            int i = 0;
            while (i < strs.Length)
            {
                ints[i] = int.Parse(strs[i]);
                i++;
            }
            return ints;
        }

        public static bool IsNumericPattern(int[] nums, out int? incrementationPattern)
        {
            if (nums == null || nums.Length < 2)
            {
                incrementationPattern = null;
                return false;
            }

            int prev = nums[0];
            int cur = nums[1];
            int curDif = cur - prev;
            incrementationPattern = curDif;
            if (nums.Length < 3)
            {
                return true;
            }
            prev = cur;
            int i = 2;
            while (i < nums.Length)
            {
                cur = nums[i];
                curDif = (cur - prev);
                if (!curDif.Equals(incrementationPattern))
                    return false;
                prev = cur;
                i++;
            }
            return true;
        }

        public static string ConvertToPascalCase(string text)
        {
            var words = text.Split(' ');
            var sb = new StringBuilder();
            foreach (string word in words)
                if (string.IsNullOrWhiteSpace(word))
                    sb.Append(" "); //multiple spaces will be treated as a new word
                else
                    sb.Append(ToTitleCaseEnforced(word));
            return sb.ToString();
        }

        public static string ToTitleCaseEnforced(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
                return word;

            char[] chars = word.ToCharArray();
            chars[0] = char.ToUpper(chars[0]);
            for (int i = 1; i < chars.Length; i++)
            {
                chars[i] = char.ToLower(chars[i]);
            }
            return new string(chars);
        }
        
    }


}
