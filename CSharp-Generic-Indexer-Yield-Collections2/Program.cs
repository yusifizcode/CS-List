using System;
using ClassLibrary;
namespace CSharp_Generic_Indexer_Yield_Collections2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Name = "salam";
            book.AuthorName = "Yusif";
            book.PageCount = 1;
            Book book1 = new Book();
            book1.Name = "sagol";
            book1.AuthorName = "Yusif";
            book1.PageCount = 2;
            Book book2 = new Book();
            book2.Name = "necesen";
            book2.AuthorName = "Yusif";
            book2.PageCount = 3;

            Library library = new Library();
            library.Books.Add(book);
            library.Books.Add(book1);
            library.Books.Add(book2);
            Console.WriteLine("--------All books--------");
            foreach (var item in library.Books)
            {
                Console.WriteLine($"book no: {item.No} | book name: {item.Name}");
            }

            Console.WriteLine("--------Find all books by name--------");
            foreach (var item in library.FindAllBooksByName("a"))
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("--------Remove all books by name--------");
            foreach (var item in library.RemoveAllBookByName("a"))
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("--------Remove all books by name--------");
            foreach (var item in library.SearchBooks("1"))
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
