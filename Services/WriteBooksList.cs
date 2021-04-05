using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Services
{
    class WriteBooksList
    {
        public static void Write(List<Book> books)
        {
            Console.WriteLine("Book's List");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.Write("Name\t  Author\t   Category\t  Language\t  Isbn\t  Publications Date");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            foreach (Book b in books)
            {
                Console.Write($"{b.Name}\t{b.Author}\t{b.Category}\t{b.Language}\t{b.Isbn}\t{b.PubDate.ToString("d")}");
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
        }
    }
}
