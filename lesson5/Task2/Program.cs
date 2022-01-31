using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store(10);

            store.AddProduct(new Article("Iphone", "Калифорния", 1300), 0);
            store.AddProduct(new Article("ПЫЛЕсос", "Китай", 1300), 1);
            store.AddProduct(new Article("Сковородка", "Калифорния", 1300), 2);

            Console.WriteLine($"{store["iphone"]}");
            Console.WriteLine($"{store["пылесос"]}");
            Console.WriteLine($"{store["сковородка"]}");

            Console.WriteLine(new string('-',30));

            Console.WriteLine($"{store[0]}");
            Console.WriteLine($"{store[1]}");
            Console.WriteLine($"{store[2]}");

        }
    }
}
