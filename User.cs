using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPTLibrary
{
    internal class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID пользователя: {UserID}");
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
