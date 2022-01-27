using System;
using System.Collections.Generic;
using System.Text;

namespace DZ2
{
    class Plane : Vehicle
    {
        public double Height { get; set; }

        public int QuantityPassengers { get; set; }

        public Plane(int x, int y, double price, int yearOfRelease,double speed)
            :base(x,y,price,yearOfRelease,speed)
        {
 
        }

        public Plane( double price, int yearOfRelease,double speed)
            : base(price, yearOfRelease,speed)
        {
            
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Высота:{Height}\n" +
                $"Количество пассажиров:{QuantityPassengers}\n" +
                $"Координата X:{X}\n" +
                $"Координата Y:{Y}\n" +
                $"Цена:{Price}\n" +
                $"Год выпуска:{YearOfRelease}\n" +
                $"Скорость:{Speed}");
        }
    }
}
