using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPTLibrary
{
    internal class Executor
    {
        public void ShowHelp()
        {
            Console.WriteLine("add_book - добавить книгу");
            Console.WriteLine("remove_book - удалить книгу");
            Console.WriteLine("find_book - найти книгу по названию");
            Console.WriteLine("all_books - указать все книги находящиеся в библеотеке");
            Console.WriteLine("add_user - добавить пользователя");
            Console.WriteLine("remove_user - удалить пользователя");
            Console.WriteLine("borrow - позаимствовать книгу");
            Console.WriteLine("return - вернуть книгу");
            Console.WriteLine();
        }

        Library library = new Library();
        public void AddBook()
        {
            Book book = new Book();
            Console.WriteLine("Введите название книги:");
            book.Title = Console.ReadLine();
            Console.WriteLine("Введите автора книги:");
            book.Author = Console.ReadLine();
            Console.WriteLine("Введите номер книги:");
            book.ISBN = Console.ReadLine();
            Console.WriteLine("Введите год публикации книги:");
            book.PublicationYear = Convert.ToInt32(Console.ReadLine());

            library.AddBook(book);
        }

        public void RemoveBook()
        {
            Console.WriteLine("Введите название книги, которую хотите удалить");
            string title = Console.ReadLine();
            Book book = library.FindBookByTittle(title);
            library.RemoveBook(book);
        }

        public void FindBook()
        {
            Console.WriteLine("Введите название книги, информацию о которой хотите узнать");
            string title = Console.ReadLine();
            Book book = library.FindBookByTittle(title);
            book.DisplayInfo();
        }

        public void AllBooks()
        {
            library.DisplayAllBooks();
        }

        public void AddUser()
        {
            User user = new User();
            Console.WriteLine("Введите имя пользователя:");
            user.Name = Console.ReadLine();
            Console.WriteLine("Введите ID пользователя:");
            user.UserID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите email пользователя:");
            user.Email = Console.ReadLine();

            library.AddUser(user);
        }

        public void RemoveUser()
        {
            Console.WriteLine("Введите имя пользователя, которого хотите удалить из базы");
            string name = Console.ReadLine();
            User user = library.FindUserByName(name);
            library.RemoveUser(user);
        }

        public void Borrow()
        {
            Borrowing borrow = new Borrowing();
            Console.WriteLine("Введите название книги, которую хотите позаимствовать:");
            string title = Console.ReadLine();
            Console.WriteLine("Введите имя пользователя, позаимствовашего книгу:");
            string name = Console.ReadLine();
            Book book = library.FindBookByTittle(title);
            User user = library.FindUserByName(name);

            Console.WriteLine("Введите ID заимствования:");
            borrow.BorrowingID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите дату заимствования:");
            borrow.BorrowDate = Console.ReadLine();
            Console.WriteLine("Введите дату возвращения:");
            borrow.ReturnDate = Console.ReadLine();
            library.RegisterBorrowing(borrow, book, user);
        }

        /* Return не работает
        public void Return()
        {
            Console.WriteLine("Введите ID заимствования:");
            int id = Convert.ToInt32(Console.ReadLine());
            Borrowing borrow = library.FindBorrowingId(id);
            Book book = borrow.Book;
            User user = borrow.User;
            library.ReturnBook(borrow, book, user);
        }
        */
    }
}
