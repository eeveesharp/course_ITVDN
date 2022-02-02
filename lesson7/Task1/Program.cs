using System;

namespace Task1
{
    class Program
    {

        static void Main(string[] args)
        {
            Train[] trains = new Train[3];

            Service.SetTrain(trains);
            Service.Sort(trains);
            Service.Show(trains);

            int numberSearch = int.Parse(Console.ReadLine());

            Service.Search(trains, numberSearch);
        }
    }
}
