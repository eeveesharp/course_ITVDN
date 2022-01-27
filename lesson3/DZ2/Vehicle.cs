using System;
using System.Collections.Generic;
using System.Text;

namespace DZ2
{
    class Vehicle
    {
        protected int X { get; set; }

        protected int Y { get; set; }

        protected double Price { get; set; }

        protected double Speed { get; set; }

        protected int YearOfRelease { get; set; }

        public Vehicle(int x, int y, double price, int yearOfRelease,double speed)
        {
            X = x;
            Y = y;
            Price = price;
            YearOfRelease = yearOfRelease;
            Speed = speed;
        }

        public Vehicle(double price, int yearOfRelease,double speed)
            :this(0,0,price,yearOfRelease,speed)
        {

        }

        public virtual void GetInfo()
        {
            Console.WriteLine(
                $"Координата X:{X}\n" +
                $"Координата Y:{Y}\n" +
                $"Цена:{Price}\n" +
                $"Год выпуска:{YearOfRelease}\n" +
                $"Скорость:{Speed}"
                );
        }
    }
}
