using LibraryApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Services
{
    class GetBooksFromFile
    {
        public static List<Book> GetAllBooks()
        {
            var books = new List<Book>();
            var json = File.ReadAllText(@"C:\Users\47458\source\repos\LibraryApp\Json\library.json");
            if (json != "")
            {
                books = JsonConvert.DeserializeObject<List<Book>>(json);
            }
            return books;
        }
    }
}
