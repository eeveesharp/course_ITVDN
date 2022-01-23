using System;
using System.Collections.Generic;
using System.Text;

namespace lesson1
{
    class Player
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Point GetPosition()
        {
            Console.WriteLine("Введите Х");
            X = GetCorrectNumber();
            Console.WriteLine("Введите Y");
            Y = GetCorrectNumber();

            return new Point(X, Y);
        }

        private int GetCorrectNumber()
        {
            int number;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Error");
            }

            return number;
        }


    }
}
