using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Tovar
    {
        public int index { get; set; } = 0;
        public string name { get; set; }  
        public decimal price { get; set; }
        public int Count { get; set; }

        public Tovar() { }
        public Tovar(string _name, decimal _price)
        {
            name = _name;
            price = _price;
            Count = 1;
        }
        public Tovar(string _name, decimal _price, int _Count)
        {
            name = _name;
            price = _price;
            Count = _Count;
           
        }
       public void AddTovar(string _name, decimal _price, int _Count)
        {
            name = _name;
            price = _price;
            Count = _Count;
        }
        public void ShowT()
        {
            Console.WriteLine("№"+index+".) Назва:" + name);
            Console.WriteLine("В наявностi:" + Count + " шт.");
            Console.WriteLine("Цiна:" + price + " грн.");
        }
    }
}

