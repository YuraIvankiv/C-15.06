using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Tovar tovar1 = new Tovar("Ноутбук", 15000);
            Tovar tovar2 = new Tovar("Телефон", 8000, 2);
            Item item = new Item();
            item.AddT(tovar1);
            item.AddT(tovar2);
            item.Menu();
        }
    }
}
