using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();         

            matrix.GetMass();
            matrix.GetMaxValue();
            matrix.GetMinValue();
            matrix.GetSum();
            matrix.GetAvarage();
            matrix.GetUnevenElements();
        }
    }
}
