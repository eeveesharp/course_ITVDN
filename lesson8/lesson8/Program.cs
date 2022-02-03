using System;

namespace lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter line");

            string str = Console.ReadLine();

            Service.ShowMenu();

            int color = int.Parse(Console.ReadLine());

            Service.Print(str, color);
        }
    }
}
