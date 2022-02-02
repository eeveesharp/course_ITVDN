using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public struct Train
    {
        public string NameDestination { get; set; }

        public int NumberOfTrain { get; set; }

        public string Time { get; set; }

        public Train(string nameDestination, int numberOfTrain, string time)
        {
            NameDestination = nameDestination;
            NumberOfTrain = numberOfTrain;
            Time = time;
        }
    }
}
