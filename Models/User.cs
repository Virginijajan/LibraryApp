using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class User
    {
        public string Name { get; set; }
        public TimeSpan PeriodBookIsTaken { get; set; }
        public DateTime Date { get; set; }
        public Book Book { get; set; }
    }
}
