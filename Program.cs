namespace GPTLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в библеотеку GPTLibrary");
            Console.WriteLine("Библеотека предоставляет функционал для хранения книг и пользователей, а также ведёт учет заимстовований книг из библеотеки");
            Console.WriteLine("Введите help чтобы узнать список доступных команда");
            Console.WriteLine("Введите exit для выхода из программы");
            Console.WriteLine();

            Executor exec = new Executor();
            while (true) {
                string input = Console.ReadLine();
                if (input == "exit")
                {
                    break;
                }
                
                switch (input)
                {
                    case "help":
                        exec.ShowHelp();
                        break;
                    case "add_book":
                        exec.AddBook();
                        break;
                    case "remove_book":
                        exec.RemoveBook();
                        break;
                    case "find_book":
                        exec.FindBook();
                        break;
                    case "all_books":
                        exec.AllBooks();
                        break;
                    case "add_user":
                        exec.AddUser();
                        break;
                    case "remove_user":
                        exec.RemoveUser();
                        break;
                    case "borrow":
                        exec.Borrow();
                        break;
                    /*
                    case "return":
                        exec.Return();
                        break;
                    */
                    default:
                        Console.WriteLine("Команда не найдена");
                        Console.WriteLine();
                        break;

                }   
            }
        }
    }
}
