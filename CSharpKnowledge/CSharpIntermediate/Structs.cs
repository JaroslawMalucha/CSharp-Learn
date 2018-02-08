using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    // STRUCT vs CLASS
    // - no inheritance
    // - no constructors so no passing arguments on instantiation
    // - data members cannot be instantiates
    // - value type (Stack) - shortlived
    // - slightly faster processed and since on a stack memory could get release faster, can be usufull if small, embedded and short-lived
    
    // STACK vs HEAP
    // - thread specific while HEAP is applciation specific
    // - allocation dealt with(planned?, deterministic) during compile, while HEAP is known at runtime only

    class Structs
    {
        static public void testStructs()
        {
            Employee newEmployee = new Employee();
            newEmployee.employeeName = "James";
            newEmployee.employeeJob = "Programmer";
            newEmployee.Salary = 5000;
            Console.WriteLine($"Employee name is {newEmployee.employeeName} " +
                $"and his job is{newEmployee.employeeJob} " +
                $"and his salary is {newEmployee.Salary}");

            Employee empl2 = newEmployee;
            empl2.Salary = 0;
            Console.WriteLine(empl2.Salary);
            Console.WriteLine(newEmployee.Salary);
            if (empl2.Salary != newEmployee.Salary)
            {
                Console.WriteLine("Struct was copied since its a value type.");
            }
        }
    }

    struct Employee
    {
        public string employeeName;
        public string employeeJob;
        private decimal salary;
        
        //private decimal salary = 0.0m; //fails to compile cannot initialize in a struct

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
