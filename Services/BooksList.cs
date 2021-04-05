using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Services
{
    class BooksList
    {
        public static void List()
        {
            Console.WriteLine("Books in Library");
            Console.WriteLine("****************");

            var books = GetBooksFromFile.GetAllBooks();
            WriteBooksList.Write(books);

            Console.WriteLine("Available filters:");
            Console.WriteLine("author, category, language, ISBN, name, taken, available");

            Console.WriteLine("Filter by:");
            var command = Console.ReadLine();


            switch (command)
            {
                
                case "author":
                    Console.WriteLine("Write author:");
                    var author = Console.ReadLine();
                    books = books.FindAll(b => b.Author == author);
                    break;
                case "category":
                    Console.WriteLine("Write category:");
                    var category = Console.ReadLine();
                    books = books.FindAll(b => b.Category == category);
                    break;
                case "language":
                    Console.WriteLine("Write language:");
                    var language = Console.ReadLine();
                    books = books.FindAll(b => b.Language ==language);
                    break;
                case "ISBN":
                    Console.WriteLine("Write ISBN:");
                    var isbn = Console.ReadLine();
                    books = books.FindAll(b => b.Isbn == isbn);
                    break;
                case "name":
                    Console.WriteLine("Write name:");
                    var bookName = Console.ReadLine();
                    books = books.FindAll(b => b.Name == bookName);
                    break;
                case "taken":
                    books = books.FindAll(b => b.IsTaken == true);
                    break;
                case "available":
                    books = books.FindAll(b => b.IsTaken == false);
                    break;
                default:
                    Console.WriteLine("bad command!");
                    break;
            }
            WriteBooksList.Write(books);
        }
    }
}
