using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Services
{
    class DeleteBook
    {
        public static void Delete()
        {
            Console.WriteLine("Book's name:");
            var name = Console.ReadLine();

            var books = GetBooksFromFile.GetAllBooks();
            var book = books.FirstOrDefault(s => s.Name == name);
            if (book == null)
            {
                Console.WriteLine("The book is not found!");
            }
            else if (book.IsTaken == true)
            {
                Console.WriteLine("The book can not be deleted because it is taken. ");
            }
            else
            {
                books.Remove(book);
                WriteToFileBook.Write(books);
                Console.WriteLine("The book has been deleted from the library!");
            }    
        }
    }
}
