using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Services
{
    public class TakeBook
    {
        public static void Take()
        {
            Console.WriteLine("User's name:");
            var name = Console.ReadLine();

            Console.WriteLine("Book's name:");
            var bookName = Console.ReadLine();

            var books = GetBooksFromFile.GetAllBooks();
            var book = books.FirstOrDefault(s => s.Name == bookName);
            if (book == null)
            {
                Console.WriteLine("The book is not in library.");
            }
            else if (book.IsTaken == true)
            {
                Console.WriteLine("The book is not available.");
            }
            else
            {
                Console.WriteLine("Period the book is taken:");
                var bookPeriodIsTakenInput = Console.ReadLine();

                if (!TimeSpan.TryParse(bookPeriodIsTakenInput, out var bookPeriodIsTaken))
                {
                    Console.WriteLine("Period is not valid!");
                }
                else if(bookPeriodIsTaken.TotalDays > 60)
                {
                    Console.WriteLine("Period can not be more than 60 days!");
                }
              
                else
                {
                    var user = new User();
                    user.Name = name;
                    user.PeriodBookIsTaken = bookPeriodIsTaken;
                    user.Date = DateTime.Now;
                    user.Book = book;

                    var users = GetUsersFromFile.GetAllUsers();
                    int userCount = 0;
                    foreach (var u in users)
                    {
                        if (u.Name == name)
                        {
                            userCount++;
                        }
                    }

                    if (userCount < 3)
                    {
                        users.Add(user);
                        WriteToFileUser.Write(users);
                        book.IsTaken = true;
                        WriteToFileBook.Write(books);
                        Console.WriteLine("The book has been taken!");
                    }
                    else
                    {
                        Console.WriteLine("To take more than three books is not allowed!");
                    }
                }
            }
        }   
    }
}

