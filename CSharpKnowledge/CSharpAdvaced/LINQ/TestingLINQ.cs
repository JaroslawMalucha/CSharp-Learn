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
            // whats LINQ:
            // Language Integrated Query Language
            // enables you to query objects:
            //  - Objects in memory like Collections, e.g. List (LINQ to Objects)
            //  - Databses (LINQ to Entities)
            //  - XML (LINQ to XML)
            //  - ADO.NET Data Sets (LINQ to Data Sets)
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


        }
    }
}
