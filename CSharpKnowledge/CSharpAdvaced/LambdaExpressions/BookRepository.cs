using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book> {
                new Book() { Title = "How to fuck up being a manager", Price = 5 },
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
            book = books.Find(x=>x.Price<10);
            var cheapBooks = books.FindAll(x => x.Price < 15);
            Func<Book, bool> cheapBooksFinder = (b => b.Price < 15); // that a Predicate(boolean Delagate) made from a Lambda Expression
            foreach (Book b in cheapBooks)
                Console.WriteLine(b.Title);
                

        }

        static bool IsCheaperThen10dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}
