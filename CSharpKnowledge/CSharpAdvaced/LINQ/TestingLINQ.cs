using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.LINQ
{
    public class TestingLINQ
    {
        public static void testingLINQ()
        {
            // LINQ - Language Integrated Query Language

            // enables you to query objects:
            //  - Objects in memory like Collections, e.g. List (LINQ to Objects)
            //  - Databses (LINQ to Entities)
            //  - XML (LINQ to XML)
            //  - ADO.NET Data Sets (LINQ to Data Sets)

            // Two Syntaxes:
            // - Method Syntax
            // - Query Syntax

            var books = new BookRepository().GetBooks();
            List<Book> cheapBooks = null;

            // TRADITIONAL WAY:
            cheapBooks =  new List<Book>();
            foreach (var book in books)
            {
                if (book.Price < 15)
                    cheapBooks.Add(book);
            }

            //LINQ Extension Methods
            IEnumerable<Book> cheapBooks2 = books.Where(b => b.Price < 15)
                                            .OrderBy(b => b.Title);
            var cheapBooks3 = books.Where(b => b.Price < 15)
                                            .OrderBy(b => b.Title)
                                            .Select(b => b.Title); //this will extract a collection of strings

            var newBook = books.Single(b => b.Title == "ASP.NET MVC"); // one and only one can be returned
            newBook = books.SingleOrDefault(b => b.Title == "ASP.NET MVC++"); // if may not contain or there are many
            try
            {
                newBook = books.Single(b => b.Title == "WebDev made simple");
            }
            catch (Exception)
            {
                Console.WriteLine(".Single Cant return if there are many");
            }
            try
            {
                newBook = books.SingleOrDefault(b => b.Title == "WebDev made simple");
            }
            catch (Exception)
            {
                Console.WriteLine(".SingleOrDefault Cant return if there are many");
            }
            newBook = books.First(b => b.Title == "WebDev made simple");
            newBook = books.Last(b => b.Title == "WebDev made simple");
            Console.WriteLine(newBook.Title + " " + newBook.Price);
            newBook = books.FirstOrDefault(b => b.Title == "WebDev made simple");

            var someBooks = books.Skip(2).Take(3); //important for paging

            var count = books.Count();
            var maxPrice = books.Max(b => b.Price);
            var minPrice = books.Min(b => b.Price);
            var sum = books.Sum(b => b.Price);



            //LINQ Query Operators  
            var cheapBooks4 = 
                from b in books
                where b.Price < 10
                orderby b.Title
                select b;

            // PRINT
            foreach (var book in cheapBooks2)
                Console.WriteLine(book.Title + " " + book.Price);







            //===========================
            // Method syntax on employees
            //===========================
            var filteredList = new List<Employees>();
            var listOfEmployees = Employees.GetEmployees();
            Employees.DisplayWithApparisal(listOfEmployees, "All Employees");

            //Salary is greater than or equal to 6000 and age greater than 40
            IEnumerable<Employees> emps = listOfEmployees.Where(e => e.Salary >= 6000 && e.Age > 40);
            filteredList = listOfEmployees.Where(e => e.Salary >= 6000 && e.Age > 40).ToList();

            //Salary is greater than or equal to 6000 and age greater than 40 or salary is greater than or equal 8000
            filteredList = listOfEmployees.Where(e => e.Salary >= 6000 && e.Age > 40 || e.Salary >= 8000).ToList();

            //===========================
            // Query syntax on employees
            //===========================

            //Salary is greater than or equal to 6000 and age greater than 40
            filteredList = (from emp in listOfEmployees
                           where emp.Salary >= 6000 && emp.Age > 40
                           select emp).ToList();
            Employees.DisplayWithApparisal(filteredList, "filtered...");

            //Salary is greater than or equal to 6000 and age greater than 40 or salary is greater than or equal 8000
            filteredList = (from emp in listOfEmployees
                            where emp.Salary >= 6000 && emp.Age > 40 || emp.Salary >= 8000
                            select emp).ToList();

            //Salary higher than 4000 and last appraisal less than 8
            filteredList = (from emp in listOfEmployees
                            where emp.Salary > 4000 && emp.Appraisal[0] < 8
                            select emp).ToList();

            // Sort by Salary
            List<Employees> sortedList = null;
            sortedList = (from emp in listOfEmployees
                          orderby emp.Salary descending, emp.Appraisal[0] descending
                          select emp).ToList();
            Employees.DisplayWithApparisal(sortedList, "sorted...");

            // Sort by Salary with a method
            sortedList = null;
            sortedList = SortEmployees(listOfEmployees);
            Employees.DisplayWithApparisal(sortedList, "sorted...");


        }

        internal static List<Employees> SortEmployees(List<Employees> list)
        {
            var list2 = from emp in list
                        orderby emp.Age descending
                        select emp;
            return list.ToList();
        }
    }
}
