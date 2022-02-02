using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public static class Service
    {
        static public void SetTrain(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("Введите пункт назначения поезда");
                trains[i].NameDestination = Console.ReadLine();

                Console.WriteLine("Введите номер поезда");
                trains[i].NumberOfTrain = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите время прибывания");
                trains[i].Time = Console.ReadLine();
            }
        }

        static public void Show(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($"Пункт назначения:{trains[i].NameDestination}\n" +
                    $"Номер поезда:{trains[i].NumberOfTrain}\n" +
                    $"Время прибытия{trains[i].Time}");
                Console.WriteLine(new string('-',30));
            }
        }

        static public void Sort(Train[] trains)
        {
            Train temp;

            for (int i = 0; i < trains.Length; i++)
            {
                for (int j = 0; j < trains.Length; j++)
                {
                    if (trains[i].NumberOfTrain > trains[j].NumberOfTrain)
                    {
                        temp = trains[i];
                        trains[i] = trains[j];
                        trains[j] = temp;
                    }
                }
            }
        }

        static public void Search(Train[] trains,int numberOfTrain)
        {
            bool isTrain = false;

            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].NumberOfTrain == numberOfTrain)
                {
                    Console.WriteLine($"Пункт назначения{trains[i].NameDestination}\n" +
                    $"Номер поезда:{trains[i].NumberOfTrain}\n" +
                    $"Время прибытия{trains[i].Time}");

                    isTrain = true;
                }
            }

            if (!isTrain)
            {
                Console.WriteLine("Нету такого поезда");
            }
        }

    }
}
