using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    public class Program
    {
        //[STAThread] // needed to initialize a WPF UI project from this thread
        public static void Main(string[] args)
        {
            Basics.Run();
            Person.testPerson();
            Calculator.TestCalculator();
            Arrays.ArraysBasics();
            Lists.testList();
            Strings.StringsBasics();
            Enumerations.testEnumerations();
            Types.testTypes();
            Conditionals.testConditionals();
            Loops.testLoops();
            Random.testRandom();
            LoopsExercise.testLoops();
            DatesAndTime.testDates();
            WorkingWithText.testStrings();
            WorkingWithFiles.testFiles();
        }
    }
}
