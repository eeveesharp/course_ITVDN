using System;

namespace DZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(200000, 2009,650)
            {
                Height = 5000,
                QuantityPassengers = 120
            };

            plane.GetInfo();

            Console.WriteLine(new string('-',30));

            Car car = new Car(15000,2010,260);

            car.GetInfo();

            Console.WriteLine(new string('-', 30));

            Ship ship = new Ship(1,23,190000, 2000, 60)
            {
                QuantityPassengers = 80,
                Port = "Владикавказ"
            };

            ship.GetInfo();
        }
    }
}
