using System;
using System.Collections.Generic;
using System.Text;

namespace DZ2
{
    class Car : Vehicle
    {
        public Car(int x, int y, double price, int yearOfRelease,double speed)
          : base(x, y, price, yearOfRelease,speed)
        {

        }

        public Car( double price, int yearOfRelease,double speed)
          : base(price, yearOfRelease,speed)
        {

        }
    }
}
