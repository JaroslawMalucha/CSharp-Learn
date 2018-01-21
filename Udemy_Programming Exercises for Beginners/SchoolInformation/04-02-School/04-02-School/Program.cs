/*
Write an application that includes two additional methods in addition to the
Main( ) method. One method should return a string consisting of four or
five lines of information about your school. The other method should return
a string consisting of asterisks. First call the method that returns the string of
asterisks. Call the method that returns the asterisk a second time after you
invoke the method that displays the information about your school. Items
you might include are the name of your school, number of students enrolled,
and school colors. Include appropriate labels. The display should be aesthetically
pleasing so include enough asterisks to surround your listing.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_02_School
{
  class Program
  {
    static void Main(string[] args)
    {
      string asterix = Asterix();
      Console.WriteLine(asterix);
      Console.WriteLine(SchoolInfo());
      Console.WriteLine(Asterix());
    }
    
    static string Asterix()
    {
      //return "***************************************************";
      /*
      string asterix = "*";
      for (int i = 0; i < 50; i++)
      {
        asterix += "*";
      }
      return asterix;
      */

      return new String('*', 50);
    }    

    static string SchoolInfo()
    {
      string schoolName = "City University of Seattle";
      string schoolCountry = "Slovakia";
      int schoolCost = 15000;
      int numOfStudents = 1000;

      string schoolInfo = String.Format("School Name:        {0}\n" +
                                        "School Country:     {1}\n" +
                                        "School Cost:        {2:C2}\n" +
                                        "Students Attending: {3}",
                                        schoolName, schoolCountry, schoolCost, numOfStudents);
      return schoolInfo;
    }
  }
}
