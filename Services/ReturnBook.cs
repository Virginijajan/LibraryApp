using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Services
{
    class ReturnBook
    {
        public static void Return()
        {
            Console.WriteLine("Book's name:");
            var name = Console.ReadLine();

            var books = GetBooksFromFile.GetAllBooks();
            var book = books.FirstOrDefault(s => s.Name == name);
            if (book == null)
            {
                Console.WriteLine("The book is not found!");
            }
            else if(book.IsTaken==true)
            {
                var users = GetUsersFromFile.GetAllUsers();
                var user = users.FirstOrDefault(s => s.Book.Name == name);
                var periode = DateTime.Now.Subtract(user.Date);

                if (periode> user.PeriodBookIsTaken)
                {
                    Console.WriteLine("The book is returned too late!");
                }
                book.IsTaken = false;
                users.Remove(user);
                WriteToFileBook.Write(books);
                WriteToFileUser.Write(users);
                Console.WriteLine("The book has been returned!");
            }
        }
    }
}
