using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Derived:Base
    {
        public int f4, f5;
        public  override void Print()
        {
            Console.WriteLine("Method Derived");
        }

        public void NVPrint()
        {
            Console.WriteLine("Method Derived");
        }
    }
}
