using System;
using System.Collections;
namespace ConsoleEnum
{

    public class car
    {
        private int year;
        private string make;

        public car(string Make, int Year)
        {
            make = Make;
            year = Year;
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
    }//end class
}//end namespace