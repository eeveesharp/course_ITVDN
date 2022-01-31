using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Matrix
    {
        public int Size { get; private set; }

        private int[] mass;

        public void GetMaxValue()
        {
            int maxValue = mass[0];

            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > maxValue)
                {
                    maxValue = mass[i];
                }
            }

            Console.WriteLine($"Max value:{maxValue}");
        }

        private void SetMass()
        {
            Random random = new Random();

            int length = GetCorrectLength();

            mass = new int[length];

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = random.Next(-100, 100);
            }
        }

        public void GetMass()
        {
            SetMass();

            Console.Write("Массив:");

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]}\t");
            }

            Console.WriteLine();
        }

        private int GetCorrectLength()
        {
            int length;

            Console.WriteLine("Введите размерность");

            while (!int.TryParse(Console.ReadLine(), out length) || length <= 0)
            {
                Console.WriteLine("Некорректная размерность");
            }

            return length;
        }

        public void GetMinValue()
        {
            int minValue = mass[0];

            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < minValue)
                {
                    minValue = mass[i];
                }
            }

            Console.WriteLine($"Min value:{minValue}");
        }

        public void GetSum()
        {
            int sum = 0;

            for (int i = 0; i < mass.Length; i++)
            {
                sum += mass[i];
            }

            Console.WriteLine($"Сумма:{sum}");
        }

        public void GetAvarage()
        {
            int sum = 0;
            double avarage;

            for (int i = 0; i < mass.Length; i++)
            {
                sum += mass[i];
            }

            avarage = (double)sum / mass.Length;

            Console.WriteLine($"Средняя :{avarage}");
        }

        public void GetUnevenElements()
        {
            List<int> unevenElements = new List<int>();

            for (int i = 0; i < mass.Length; i++)
            {
                if (!(mass[i] % 2 == 0))
                {
                    unevenElements.Add(mass[i]);
                }
            }

            Console.Write("Нечетные числа массива: ");

            for (int i = 0; i < unevenElements.Count; i++)
            {
                Console.Write($"{unevenElements[i]}\t");
            }
        }
    }
}
