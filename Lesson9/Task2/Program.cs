using System;

namespace Task2
{
    class Program
    {
        public delegate int Delegate();

        public delegate double ArrayDelegate(Delegate[] array);

        static void Main(string[] args)
        {
            GetAvarage();
        }

        static private int GetRandomElements()
        {
            Random rnd = new Random();

            int randomElement = rnd.Next(1, 100);

            return randomElement;
        }

        static private void SetArray()
        {
            Console.WriteLine("Введите число элементов");

            int length = int.Parse(Console.ReadLine());

            var array = new Delegate[length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = () => { return GetRandomElements(); };
            }
        }

        //static private Delegate[] GetArray()
        //{
        //    Delegate[] array = SetArray();

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.Write(array[i].Invoke() + " ");
        //    }

        //    return array;
        //}

        static private void GetAvarage()
        {
            Console.WriteLine("Введите число элементов");

            int length = int.Parse(Console.ReadLine());

            var array = new Delegate[length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = () => { return GetRandomElements(); };
            }

            ArrayDelegate arrayDelegate = delegate (Delegate[] mass)
            {
                double sum = 0;

                double avarage = 0;

                for (int i = 0; i < mass.Length; i++)
                {
                    int element = mass[i].Invoke();
                    sum += element;

                    Console.WriteLine(element);
                }

                //avarage = sum / array.Length;
                return sum / array.Length;
            };

            Console.WriteLine($"Среднее значение {arrayDelegate.Invoke(array)}");
        }
    }
}
