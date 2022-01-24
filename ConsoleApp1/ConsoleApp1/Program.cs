using System;

namespace ConsoleApp1
{
    class Program
    {
        public readonly string field = "hello";

        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine(program.field);
        }
    }
}
