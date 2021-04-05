using LibraryApp.Services;
using System;

namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************");
            Console.WriteLine("LIBRARY");
            Console.WriteLine("**************");
            Console.WriteLine("Available commands:");
            Console.WriteLine("Add-book, Take-book, Return-book, List, Delete-book, End");

            bool end = false;
            do
            {
                Console.WriteLine("Write a command:");
                var command = Console.ReadLine();

                switch (command)
                {
                    case "Add-book":
                        AddNewBook.AddBook();
                        break;
                    case "Take-book":
                        TakeBook.Take();
                        break;
                    case "Return-book":
                        ReturnBook.Return();
                        break;
                    case "List":
                        BooksList.List();
                        break;
                    case "Delete-book":
                        DeleteBook.Delete();
                        break;
                    case "End":
                        end = true;
                        break;
                    default:
                        Console.WriteLine("Bad command:");
                        break;
                }
            } while (end == false);
        }
    }
}
