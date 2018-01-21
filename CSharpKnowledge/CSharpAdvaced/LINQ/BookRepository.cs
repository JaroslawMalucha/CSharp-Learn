using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.LINQ
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "C# In Depth", Price = 20.99 },
                new Book() {Title = "R for Dummies", Price = 5.00 },
                new Book() {Title = "WebDev made simple", Price = 14.99 },
                new Book() {Title = "WebDev made simple", Price = 24.99 },
                new Book() {Title = "ASP.NET MVC", Price = 19.99 },
                new Book() {Title = "C# Quick Reference Guide", Price = 5.99 }
            };
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public double Price { get; set; }

    }

}
