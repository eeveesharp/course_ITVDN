using System;
using System.Collections.Generic;
using System.Text;

namespace lesson8
{
    static class Service
    {
        static public void Print(string str, int color)
        {
            switch (color)
            {
                case (int)Color.Red:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    }
                case (int)Color.Green:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    }
                case (int)Color.Blue:
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    }
                default:
                    Console.WriteLine("color is default");
                    break;
            }

            Console.WriteLine(str);
        }

        static public void ShowMenu()
        {
            Console.WriteLine("Enter color");

            Console.WriteLine($"Red - {(int)Color.Red}\n" +
                $"Green - {(int)Color.Green}\n" +
                $"Blue - {(int)Color.Blue}\n");
        }
    }
}
