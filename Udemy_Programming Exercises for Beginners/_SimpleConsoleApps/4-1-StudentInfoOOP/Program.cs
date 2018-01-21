/*
Create a class representing a student. Include characteristics such as student
number, first and last name, overall GPA, classification, and major. Write at least
two constructors. Include properties for each of the data items. Create a second
class that instantiates the first class with information about yourself. In the
second class, create a class method that displays your name and GPA.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_StudentInfoOOP
{
  class Program
  {
    static void Main(string[] args)
    {
      StudentDetails sd = new StudentDetails();
      sd.displayOutput();
    }
  }
}
