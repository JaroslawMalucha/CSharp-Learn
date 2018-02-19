using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.LambdaExpressions
{
    public class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
    }

    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book> {
                new Book() { Title = "How to explain what has no meaning", Price = 5 },
                new Book() { Title = "Notorious Juggler", Price = 7 },
                new Book() { Title = "Who walked on a wing", Price = 3926 }
            };
        }

        public static void testBookRepo()
        {
            var books = new BookRepository().GetBooks();
            Book book;
            foreach (Book b in books)
            {
                if (b.Price < 10)
                {
                    book = b;
                    break;
                }
            }
            book = books.Find(IsCheaperThen10dollars);
            book = books.Find(x => x.Price < 10);
            var cheapBooks = books.FindAll(x => x.Price < 15);
            Func<Book, bool> cheapBooksFinder = (b => b.Price < 15); // that is a saved Predicate(boolean Delagate) made from a Lambda Expression
            foreach (Book b in cheapBooks)
                Console.WriteLine(b.Title);


        }

        // a predicate that can be used with, e.g. list methods
        static bool IsCheaperThen10dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}
