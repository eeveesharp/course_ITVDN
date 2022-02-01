using System;
using System.Collections.Generic;
using System.Text;

namespace lesson6
{
    static class StaticClass
    {
        public static void Method()
        {
            Console.WriteLine("Вызов методы в статик классе");
        }

        public static double Plus(double a,double b)
        {
            double sum = a + b;

            return sum;
        }
    }
}
