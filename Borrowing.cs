using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPTLibrary
{
    internal class Borrowing
    {
        public int BorrowingID { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }
        public string BorrowDate { get; set; }
        public string ReturnDate { get; set; }

        
        public void DisplayInfo()
        {
            Console.WriteLine($"ID взаимствования: {BorrowingID}");
            Console.WriteLine($"Книга: {Book.Title}");
            Console.WriteLine($"Имя пользователя: {User.Name}");
            Console.WriteLine($"Дата заимствования: {BorrowDate}");
            Console.WriteLine($"Дата возврата: {ReturnDate}");
        }
    }
}
