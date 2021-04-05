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
    class GetUsersFromFile
    {
        public static List<User> GetAllUsers()
        {
            var users = new List<User>();
            var json = File.ReadAllText(@"C:\Users\47458\source\repos\LibraryApp\Json\users.json");
            if (json != "")
            {
                users = JsonConvert.DeserializeObject<List<User>>(json);
            }
            return users;
        }
    }
}
