using System;

namespace lesson5
{
    class Program
    {
        class MyClass
        {
            private int[] arr = new int[5];

            public int this[int index]
            {
                get
                {
                    return arr[index];
                }

                set
                {
                    arr[index] = value;
                }
            }
        }
        static void Main(string[] args)
        {
            MyClass my = new MyClass();

            my[0] = 5;

            Console.WriteLine(my[2]);
        }
    }
}
