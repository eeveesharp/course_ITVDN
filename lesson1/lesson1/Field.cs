using System;
using System.Collections.Generic;
using System.Text;

namespace lesson1
{
    class Field
    {
        public string[,] PlayField { get; set; }

        public int Size { get; set; }

        public void SetField()
        {
            Console.WriteLine("Введите размер поля");

            Size = GetCorrectNumber();

            PlayField = new string[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    PlayField[i,j] = "#";
                }
            }
        }

        public void GetField()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Console.Write($"{PlayField[i,j]}");
                }

                Console.WriteLine();
            }
        }

        private int GetCorrectNumber()
        {
            int number;

            while (!int.TryParse(Console.ReadLine(),out number) || number <= 2)
            {
                Console.WriteLine("Error");
            }

            return number;
        }
    }
}
