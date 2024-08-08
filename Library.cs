using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GPTLibrary
{
    internal class Library
    {
        public List<Book> Books { get; set; }
        public List<User> Users { get; set; }
        public List<Borrowing> Borrowings { get; set; }

        //Инициализация списков
        public Library()
        {
            Books = new List<Book>();
            Users = new List<User>();
            Borrowings = new List<Borrowing>();
        }

        // Методы работы с Books
        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"Книга {book.Title} была добавлена в библеотеку");
            Console.WriteLine();
        }

        public void RemoveBook(Book book)
        {
            Books.Remove(book);
            Console.WriteLine($"Книга {book.Title} была удалена из библеотеки");
            Console.WriteLine();
        }

        public Book FindBookByTittle(string title)
        {
            return Books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        public void DisplayAllBooks()
        {
            if (Books.Count == 0)
            {
                Console.WriteLine("В библеотеке нет книг");
                Console.WriteLine();
                return;
            }

            Console.WriteLine("Список книг в библеотеке:");
            foreach (var book in Books)
            {
                book.DisplayInfo();
                Console.WriteLine();
            }
        }


        //Методы работы с Users
        public void AddUser(User user)
        {
            Users.Add(user);
            Console.WriteLine($"Пользователь {user.Name} был добавлен в базу");
            Console.WriteLine();
        }

        public void RemoveUser(User user)
        {
            Users.Remove(user);
            Console.WriteLine($"Пользователь {user.Name} был удалён из базы");
            Console.WriteLine();
        }

        public User FindUserByName(string name)
        {
            return Users.Find(b => b.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }


        //Методы работы с Borrowing
        public void RegisterBorrowing(Borrowing borrowing, Book book, User user)
        {
            Console.WriteLine($"Книга {book.Title} была позаимствована до {borrowing.ReturnDate} пользователем {user.Name}");
            Borrowings.Add(borrowing);
            Books.Remove(book);
            Console.WriteLine();
        }

        public void ReturnBook(Borrowing borrowing, Book book, User user)
        {
            Console.WriteLine($"Книга {book.Title} была возвращена в библеотеку пользователем {user.Name}");
            Borrowings.Remove(borrowing);
            Books.Add(book);
            Console.WriteLine();
        }

        public Borrowing FindBorrowingId(int ID)
        {
            return Borrowings.Find(b => b.BorrowingID == ID);
        }
    }
}
