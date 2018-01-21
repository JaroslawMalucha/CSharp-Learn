using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_StudentInfoOOP
{
  class StudentDetails
  {
    Student st = new Student("Pavol", "Smith", 3.9f);
    Student st2 = new Student(13, "Peter", "Griffin", 1.0f);

    public void displayOutput()
    {
      st.StudentId = 101;
      Console.WriteLine("{0} {1}'s GPA is {2:F2}", st.FirstName, st.LastName, st.GPA);
      Console.WriteLine("Pavol's ID is {0} ", st.StudentId);
      Console.WriteLine("Student ID is {0}. {1} {2}'s GPA is {3:F2}", st2.StudentId, st2.FirstName, st2.LastName, st2.GPA);
    }
  }
}
