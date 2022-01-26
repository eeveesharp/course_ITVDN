using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Base
    {
        public int f1,f2,f3;

        public virtual void Print()
        {
            Console.WriteLine("Method Base");
        }

        public  void NVPrint()
        {
            Console.WriteLine("Method Base");
        }
    }
}
