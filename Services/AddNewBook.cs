using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Services
{
    public class AddNewBook
    {
        public static void AddBook()
        {
            var books = GetBooksFromFile.GetAllBooks();
            var book = new Book();

            Console.WriteLine("Add books name:");
            book.Name=Console.ReadLine();

            Console.WriteLine("Add books author:");
            book.Author = Console.ReadLine();

            Console.WriteLine("Add books category:");
            book.Category = Console.ReadLine();

            Console.WriteLine("Add books language:");
            book.Language = Console.ReadLine();

            Console.WriteLine("Add books publications date:");
            var dateInput = Console.ReadLine();
           
            if(DateTime.TryParse(dateInput, out DateTime val))
            {
                book.PubDate = val;
            }

            Console.WriteLine("Add book's ISBN:");
            book.Isbn = Console.ReadLine();

            books.Add(book);
            WriteToFileBook.Write(books);

            Console.WriteLine("The book has been added to the library!");
        }
    }
}
