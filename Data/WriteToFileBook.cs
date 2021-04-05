using LibraryApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace LibraryApp.Services
{
    public class WriteToFileBook
    {
        public static void Write(List<Book> books)
        {  
            string newJson = JsonConvert.SerializeObject(books);
            File.WriteAllText(@"C:\Users\47458\source\repos\LibraryApp\Json\library.json", newJson);
        }
    }
}
