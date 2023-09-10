using System.Collections.Concurrent;

namespace Library
{
    internal class Program
    {
        public static ConcurrentDictionary<string, int> library = new ConcurrentDictionary<string, int>();
        public static async Task Main(string[] args)
        {
            SecondThread secondThread = new SecondThread();
            var task = new Task(() => secondThread.Percent());
            task.Start();
            Console.WriteLine("1 - добавить книгу; 2 - вывести список непрочитанного; 3 - выйти");
            ConsoleKeyInfo key = Console.ReadKey(true);
            while (key.Key != ConsoleKey.D3)
            {
                if (key.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("Введите название книги");
                    InputWord();
                    Console.WriteLine("1 - добавить книгу; 2 - вывести список непрочитанного; 3 - выйти");
                    key = Console.ReadKey(true);
                }
                else if (key.Key == ConsoleKey.D2)
                {
                    Library();
                    Console.WriteLine("1 - добавить книгу; 2 - вывести список непрочитанного; 3 - выйти");
                    key = Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Вы ввели непонятную команду");
                    key = Console.ReadKey(true);
                }
            }
        }
        public static void InputWord()
        {
            var word = Console.ReadLine();
            var examinationWord = library.ContainsKey(word);
            if (examinationWord == false)
            {
                library.TryAdd(word, default);
            }
        }
        public static void Library()
        {
            foreach (var key in library)
            {
                Console.WriteLine($"Книга - {key.Key}, прочитано {key.Value}%");
            }
        }
    }
}