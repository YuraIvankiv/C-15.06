using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp4
{
    internal class Item
    {
        public List<Tovar> tovars = new List<Tovar>();
        public Hashtable basket = new Hashtable();
        public decimal Price=0;

        public Item() { }

        public void AddT(Tovar tovar)
        {
            tovars.Add(tovar);
            tovar.index=tovars.Count();
        }
        public void ShowB()
        {
            Console.Clear();
            Console.WriteLine("Обранi товари в кошику:");

            foreach (DictionaryEntry entry in basket)
            {
                Tovar tovar = (Tovar)entry.Key;
                int count = (int)entry.Value;
               
                Console.WriteLine("№" + tovar.index + ".)" + tovar.name);
                Console.WriteLine("Кiлькiсть: " + count);
                Console.WriteLine("Цiна за штуку: " + tovar.price + " грн.");
                Console.WriteLine("________________________");
            }

        }
        public void ShowItem()
        {
            Console.WriteLine("Доступнi товари:");
            foreach (Tovar tovar in tovars)
            {
                tovar.ShowT();
                Console.WriteLine("________________________");
            }
        }
        public void Menu()
        {
            Console.WriteLine("Доброго дня!");
            Console.WriteLine("Щоб добавити товар в кошик ведiть його порядковий номер!");
            Console.WriteLine("Щоб вийти з меню натистiнь 0");
            for (int i = 0; i < 1; i++)
            {
                ShowItem();
                Console.WriteLine("Бажаєте щось купити:");
                int a= Convert.ToInt32(Console.ReadLine());
                if(a>0 && a<=tovars.Count())
                {
                    basket.Add(tovars.ElementAt(a-1), a);
                    i--;
                    Console.Clear();
                    Console.WriteLine("Обраний товар доданов кошик, якщо ви закiнчили обирати натиснiть 0.");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Дякую гарного дня");
                }
            }
            if(basket.Count!=0)
            {
                ShowB();
                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine("Все вiрно натиснiть 0 якщо бажаєте видалити товар з кошика настинiть його номер:");
                    int a = Convert.ToInt32(Console.ReadLine());
                    if(a==0)
                    {
                        Console.Clear();
                        ShowBills();
                    }
                    else if(a>0 && a<=tovars.Count)
                    {
                        basket.Remove(tovars.ElementAt(a-1));
                        i--;
                    }
                    else { Console.WriteLine("Error"); }

                }

            }
            else { Console.WriteLine("Дякую гарного дня"); }
        }
        public void ShowBills()
        {
          
            Console.WriteLine("Рахунок:");
            foreach (DictionaryEntry entry in basket)
            {
                Tovar tovar = (Tovar)entry.Key;
                int count = (int)entry.Value;

                Console.WriteLine( tovar.name);
                Price += tovar.price;
            }
           
            Console.WriteLine("Сума до сплати:" + Price);
            Console.WriteLine("Дякую за покупку гарного дня=)");
        }

    }
}
