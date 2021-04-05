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
    class WriteToFileUser
    {
        public static void Write(List<User> users)
        {
            string newJson = JsonConvert.SerializeObject(users);
            File.WriteAllText(@"C:\Users\47458\source\repos\LibraryApp\Json\users.json", newJson);
        }
    }
}
