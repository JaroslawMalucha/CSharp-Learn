using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_StudentInfoOOP
{
  class Student
  {
    public Student(string firstName, string lastName,float gpa)
    {
      FirstName = firstName;
      LastName = lastName;
      GPA = gpa;
    }

    public Student(int id, string firstName, string lastName, float gpa)
    {
      StudentId = id;
      FirstName = firstName;
      LastName = lastName;
      GPA = gpa;
    }

    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public float GPA { get; set; }
  }
}
