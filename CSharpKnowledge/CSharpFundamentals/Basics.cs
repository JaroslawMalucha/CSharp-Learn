﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class Basics
    {
        public static void Run()
        {
            //SINGLE LINE COMMENTS
            /*
             *MULTI LINE COMMENTS
            */
            // COMMNETING GOOD PRACTICE
            // KEEP'EM TO A MINIMUM CUZ NOBODY UPDATES THEM
            // USE FOR whys, hows, constrains
            // DONT USE FOR what its doing


            // NAMING CONVENTIONS !!!
            // Formal:
            //  - camelCase - variables, parameters
            //  - _[varName] - private fields, eg. _privateVariableField, _PrivateConstant
            //  - PascalCase - constants, Methods, Properties, Public Fields, Classes, etc. (why constants: constants should be considered as encapsulated abstractions, they often get changed later to global procuderues so PascalCase will not break the rest of the code)
            //  - CAPS_SNAKE - magic global constants (usually you should use PascalCase, read above)
            // Heuristic:
            //  - Do choose easily readable names (HorizontalAlignment more english than AlignmentHorizontal, although heavy use of intelliSense prefers Categorized Naming)
            //  - Do favor readability over brevity (GetProductCoded is better than GetProCod)
            //  - Avoid using identifiers that conflict with keywords of wildly used programming langiages
            //  - Avoid using numeric and special symbols

            //Other notation standards:
            // camelCase
            // PascalCase
            // snake_case
            // kebab-case

            //Usefull Shortcuts
            //PROJECT:
            //  CTRL + SHIFT + S - save all files
            //  CTRL + ALT + C - new class file
            //EDITION
            // CTR + K, CTRL + D - autoformt XML, or any othher code
            //  TAB TAB - insert snippet
            //  CTRL + X - delete Line
            //  CTRL + arrows - move lines
            //  ALT + ENTER  or CTRL + .  - quick actions and refactorings
            //  CTRL + K, CTRL + C - comment block
            //  CTRL + K, CTRL + U - un-comment block
            //  SHIFT + ENTER - next line with punctuation auto-complete
            //VIEW:
            //  CTRL + M, CTRL + O - collapse to definitions
            //PANES:
            //  CTRL + ALT + J - Object Browser

            //////DEBUGING:
            //  F5 - Run in Debug Mode
            //  CTRL + F5 - Run without Debug
            //  SHIFT + F5 - exit Debug Mode and continue application without debug
            //  CTRL+SHIFT+F5 - restart application in Debug Mode


            //  CTRL + Shift + B - Compile/Build

            //  F10 - Step Over - one line without going inside of the called method/property/field
            //  F11 - Step Into - every executed intruction/declaration/expresion/entry point/exit point/ block start/ block end
            //  F11 + SHIFT - Step Out

            //  F9 - place Breakpoint
            //  CTRL+SHIFT+F9 - remove all Breakpoints


            //////DEBUGGING WINDOWS:
            ////// some are visible only in debug mode
            ////// Debug>Windows>Watch>[WindowName]
            // Watch - manualy select expressions you want to look at
            // Locals - all actualy declared local variables in current context
            // Autos - selection of values around current instruction: variables, methods, literals, properties
            // Breakpoints - pause execution in Debug Mode
            // CallStack - current call stack, i.e. current path of calls from program start to current instruction


            //// EXTENSIONS:
            // Productivity Power Tools



            ////SNIPPETS:
            // prop - auto property
            // cw - Console.WriteLine
            // ctor - constructor
            // try - try catch
            // /// - ??? documentation or sth



            Basics.ConsoleBasics();
            Basics.BuiltInTypes();
            Basics.TypeConversion();
            Basics.Operators();
            Basics.otherstufff();
        }

        public static void ConsoleBasics()
        {
            //CONSOLE WRITELINE ALWAYS EXECUTES "Object.ToString" on a passed object
            Console.Clear();
            Console.Beep();
            Console.WriteLine("Hello World");
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("CYAN CYAN CYAN CAT ;PPPPPPPPP");
            Console.ResetColor();
        }

        public static void BuiltInTypes()
        {



            // INTEGRAL NUMBERS
            byte b = 2 ^ 8 - 1; System.Byte b2 = Byte.MaxValue; Console.WriteLine(b);     //255; //1byte //UN-SIGNED
            sbyte sb = 2 ^ 7 - 1; System.SByte sb2 = SByte.MaxValue; Console.WriteLine(b);     //127; //1byte // SIGNED
            short s = 2 ^ 15 - 1; System.Int16 s2 = Int16.MaxValue; Console.WriteLine(s);   //32767; //2bytes
            ushort us = 2 ^ 16 - 1; System.UInt16 us2 = UInt16.MaxValue; Console.WriteLine(s);   //32767*2; //2bytes
            int i = 2 ^ 31 - 1; System.Int32 i2 = Int32.MaxValue; Console.WriteLine(i);    //2147483647 //4bytes // MOST USED
            uint ui = 2 ^ 32 - 1; System.UInt32 ui2 = UInt32.MaxValue; Console.WriteLine(i);    //2147483647*2 //4bytes
            long lng = 2 ^ 63 - 1; System.Int64 lng2 = Int64.MaxValue; Console.WriteLine(lng); //9223372036854775807L //8bytes
            ulong ulng = 2 ^ 64 - 1; System.UInt64 ulng2 = UInt64.MaxValue; Console.WriteLine(lng); //9223372036854775807L*2 //8bytes


            // REAL NUMBERS - //C# compiler treats real numbers as double
            float f = (float)3.4028234663852886E38 - 1; Console.WriteLine(f); //3.4*10^38  //4bytes
            f = 2.5f; System.Single f2 = 0; Console.WriteLine(f);
            double dbl = 4.9E-324; System.Double dbl2 = 0; Console.WriteLine(dbl);                                 //8bytes
            decimal dec = 0; System.Decimal dec2 = 0; Console.WriteLine(dec);  // (decimal) 7.9 * 10 ^ 28;                  //16bytes

            //PRECICION COMPARISON
            f = 1 / 3f; Console.WriteLine(f);
            dbl = 1 / 3d; Console.WriteLine(dbl);
            dec = 1 / 3m; Console.WriteLine(dec);

            //FORCING A NUMERIC TYPE ON A LITERAL NUMBER USING [literal number suffixes]
            ui = 0U;
            ulng = 0UL;
            lng = 0L;
            f = 0.0f;
            dbl = 0.0d;
            dec = 0.0m;

            //CHARACTER
            char chr = 'A'; System.Char chr2 = 'B'; Console.WriteLine(chr);                            //2bytes Unicocde Character

            //STRING = an Object Type
            string str = "Yolk"; System.String str2 = "Baal"; Console.WriteLine(str);

            //BOOLEAN
            bool booll = true; System.Boolean booll2 = false; Console.WriteLine(booll);  //1byte

            //OVERFLOWING - no overflow checking by default
            byte num = 255; Console.WriteLine(num);
            num = (byte)(num + 1); Console.WriteLine(num);// evorflow happens => no exception thrown => value is 

            try
            {
                checked
                {
                    num = 255;
                    num = (byte)(num + 1); // no evorflow => exception thrown
                }
            }
            catch (Exception)
            {
                Console.WriteLine(num);

                //throw;
            }
            finally
            {

            }

            //VAR - assumes the type of content once during initialization
            var numer = 10.4f;

            // MIN and MAX VALUES of a TYPE
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            //CONSTANTS
            const float Pi = 3.15f; //Pi = 1; cant reassign

            //DECLARING MULTIPLE VARIABLES
            string aa, bb, cc, dd;

            //CHECKING TYPE
            Console.WriteLine(typeof(string).IsPrimitive);
            Console.WriteLine(typeof(decimal).IsPrimitive);
            Console.WriteLine(typeof(double).IsPrimitive);
            Console.WriteLine(typeof(byte).IsPrimitive);


            // DIGIT SEPARATOR SYNTAX
            var bignum = 112_421_421_111_000;
            Console.WriteLine(bignum);

            // default KEYWORD
            DateTime dt = default; // C# 7.1+ // change in project properties>build>advanced
            Console.WriteLine(dt);

        }

        public static void TypeConversion()
        {
            //LITERALS CONVERSION
            // numeric litterals are treated as double when writeen with a period or as integer otherwise
            // all below rules apply
            double dbl = double.MaxValue; // its a double
            byte b = 255;   // its an integer auto-casted to a byte
            int i = b;      // its a byte auto-casted to an int
            float f = 9.8f; // treated explitly as float, not as double
            string str = "1234";

            //IMPLICIT TYPE CONVERSION - AUTO CASTING
            //  - works auto if full compatibility(type and size) - no data loss
            //  - will not compile if no type or size compatibility, e.g. b = i;
            i = b;

            /////EXLICIT TYPE CONVERSION
            //  - evaluates to a given type, so after evaluation auto-casting rules apply
            //EXPLICIT CASTING
            //  - if SIZE is not compatible OVERFLOWS, i.e. data loss 
            //  - if TYPE is not compatible DOES NOT COMPILE, -> e.g. i = "123"; i = "ABC";
            f = (float)dbl; // double explicitly casted to a float -> can overflow
            i = 3215;
            b = (byte)i; // data loss and data corruption
            sbyte sb = (sbyte)i; // data loss and data corruption
            //PARSING OF NON-COMPATIBLE TYPES
            //  - if SIZE is not compatible THROWS EXCEPTION, -> e.g. b = "1234";
            //  - if TYPE is not compatible THROWS EXCEPTION, -> e.g. b = "ABC";
            //b = byte.Parse("ABCD");//THROWS EXCEPTION
            //b = byte.Parse("1234");//THROWS EXCEPTION
            b = byte.Parse("123");
            //CONVERSION OF NON-COMPATIBLE TYPES
            //  - if SIZE is not compatible THROWS EXCEPTION, e.g. b=i;
            //  - if TYPE is not compatible THROWS EXCEPTION, e.g. 
            //b = Convert.ToByte("ABCD");//THROWS EXCEPTION
            //b = Convert.ToByte("1234");//THROWS EXCEPTION
            b = Convert.ToByte("123");
            try
            {
                b = Convert.ToByte("1234");
            }
            catch (Exception)
            {
                Console.WriteLine("The number 1234 could not be converted to a byte");
            }

            // TRY PARSE
            if (int.TryParse("121", out int newINT))
                Console.WriteLine("Conversion successfull, numer is: " + newINT);

        }

        public static void Operators()
        {
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/

            int a = 2;
            int b = 3;
            double c = 0;
            bool bb = false;

            //Arytmetic
            c = a + b;
            c = a - b;
            c = a * b;
            c = a / b;
            c = 2 / 3; // integer division disposes of the remainder => outputs 0
            c = 2 / 3f; // this lets C# to treat it the output of the opertaion as a float => outputs 0.(6)
            c = b % a; //remainder, modulo

            //Incrementaion
            c = a++; c = ++a;
            c += a; c -= a;
            c++;
            ++c;
            c--;
            --c;

            //Comparison
            bb = a == b;
            bb = a != b;
            bb = a > b;
            bb = a < b;
            bb = a <= b;
            bb = a >= b;

            //Assignment
            c = a;
            c += a;
            c -= a;
            c *= a;
            c /= a;

            //Logical - for boolean expressions
            bb = a == a && b == b;
            bb = a == a || a == b;
            bb = !(a == a);

            //Logical tertiary operator (aka Elvis Operator), short-circuiting
            bb = (true) ? true : false;

            //Bitwise
            int flagMaskA = 2 ^ 1;
            int flagMaskB = 2 ^ 2;
            int flagContainer = flagMaskA + flagMaskB + 1235;
            int flagMaskingResult = 0;
            flagMaskingResult = (flagContainer & flagMaskA);



            // &
            // |

            // Null Coalescing Operator - ??
            DateTime? dateTime = null; 
            Console.WriteLine(dateTime ?? DateTime.Today);

            // Null-conditional Operators , short-circuiting
            // also named Safe Navigation operator
            Console.WriteLine("is null: " + dateTime?.ToLongDateString()  ==  null);
        }


        public static void otherstufff()
        {
            goto iLoveLabelsAndGoTosNOT;
            System.Diagnostics.Debug.WriteLine("test ;)");
            
            iLoveLabelsAndGoTosNOT:
            System.Diagnostics.Debug.WriteLine("test ;("); // prints to Output window

        }

    }
}

