using EFSample1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstWithDotnetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryBooks();
        }

        private static void DeleteBook()
        {
            using (var context = new BooksContext())
            {
            //    context.Database.Log += Console.WriteLine;

                Book b = context.Books.Find(5);
                context.Books.Remove(b);
                context.SaveChanges();
            }
        }

        private static void UpdateBook()
        {
            using (var context = new BooksContext())
            {
                // context.Database.Log += Console.WriteLine;

                Book book = context.Books
                    .FirstOrDefault(b => b.Title.StartsWith("Professional C# 6"));

                Book book2 = context.Books
                    .Where(b => b.Publisher == "Wrox Press")
                    .OrderBy(b => b.Title)
                    .Skip(1).FirstOrDefault();

                book.Title = "Professional C# 6 and .NET Core 1.0";
                int records = context.SaveChanges();
                Console.WriteLine($"{records} records written");
            }
        }

        private static void QueryBooks()
        {
            using (var context = new BooksContext())
            {
              //  context.Database.Log += Console.WriteLine;

                var q = context.Books
                    .Where(b => b.Publisher == "Wrox Press")
                    .OrderBy(b => b.Title)
                    .Take(3);

                foreach (var b in q)
                {
                    Console.WriteLine($"{b.Title} {b.Publisher}");
                }

            }
        }

        private static void ReadBooks()
        {
            using (var context = new BooksContext())
            {
                var books = context.Books;
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.Title} {book.Publisher} {book.BookId}");
                }
            }
        }

        private static void CreateABook()
        {
            using (var context = new BooksContext())
            {
                var b1 = new Book { Title = "Professional C# 7", Publisher = "Wrox Press" };
                context.Books.Add(b1);
                int records = context.SaveChanges();
                Console.WriteLine($"{records} records written");
            }
        }
    }
}
