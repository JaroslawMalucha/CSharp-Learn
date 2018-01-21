using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoXML
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int TotalMarks { get; set; }

        public static Student[] GetAllStudents()
        {
            Student[] students = new Student[4]{
                new Student {Id = 101, Name = "Mark", Gender = "Male", TotalMarks = 800},
                new Student {Id = 102, Name = "Rosy", Gender = "Female", TotalMarks = 900},
                new Student {Id = 103, Name = "Pam", Gender = "Female", TotalMarks = 850},
                new Student {Id = 104, Name = "John", Gender = "Male", TotalMarks = 950}
                };
            return students;
            
        }
    }
}
