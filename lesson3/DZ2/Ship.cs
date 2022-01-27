using System;
using System.Collections.Generic;
using System.Text;

namespace DZ2
{
    class Ship : Vehicle
    {
        private int quantityPassengers;

        private string port;
        public int QuantityPassengers
        {
            get
            {
                return quantityPassengers;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Количество не может быть отрицательным");
                }
                else
                    quantityPassengers = value;
            }
        }

        public string Port
        {
            get
            {
                return port;
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Порт не задан");
                }
                else port = value;
            }
        }

        public Ship(int x,int y,double price,int yearOfRelease,double speed)
            :base(x,y,price,yearOfRelease,speed)
        {

        }

        public Ship(double price, int yearOfRelease, double speed)
           : base(price, yearOfRelease, speed)
        {

        }

        public override void GetInfo()
        {
            Console.WriteLine($"Порт:{Port}\n" +
                $"Количество пассажиров:{QuantityPassengers}\n" +
                $"Координата X:{X}\n" +
                $"Координата Y:{Y}\n" +
                $"Цена:{Price}\n" +
                $"Год выпуска:{YearOfRelease}\n" +
                $"Скорость:{Speed}");
        }
    }
}
