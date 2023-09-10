using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Regular_Customer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            Customer customer = new Customer();
            shop.changed.CollectionChanged += customer.ChangedItem;
            Console.WriteLine("Нажмите клавишу А, чтобы ввести новый товар " +
                "\n Нажмите клавишу D, чтобы удалить какой товар нужно удалить " +
                "\n Нажмите клавишу X, чтобы выйти из программы");
            Choice(shop);
        }
        public static void Choice(Shop shop)
        {
            Random rnd = new Random();
            ConsoleKeyInfo key = Console.ReadKey(true);
            while (key.Key != ConsoleKey.X)
            {
                if (key.Key == ConsoleKey.A)
                {
                    Item item = new Item() { name = $"Товар от {DateTime.Now.ToString()}", id = rnd.Next(0, 100) };
                    shop.Add(item);
                    key = Console.ReadKey(true);
                }
                else if (key.Key == ConsoleKey.D)
                {
                    Console.WriteLine("Какой товар нужно удалить? Введите его идентификатор");
                    var idItem = Console.ReadLine();
                    int deletedItem = int.Parse(idItem);
                    shop.Deleted(deletedItem);
                    key = Console.ReadKey(true);
                }
            }
        }
    }
}