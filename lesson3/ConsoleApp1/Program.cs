using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Derived derived = new Derived();
            derived.Print();
            derived.f1 = 8;
            derived.f2 = 8;
            derived.f3 = 8;

            derived.f4 = 8;
            derived.f5 = 8;

            Base derivedUp = derived;
            derivedUp.Print();
            derivedUp.NVPrint();

            Derived derivedDown = derivedUp as Derived;
            derivedDown.Print();
            derivedDown.NVPrint();

            Base instence = (Base)derived;

            Console.WriteLine(instence.f1);
            Console.WriteLine(instence.f2);
            Console.WriteLine(instence.f3);


        }
    }
}
