using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            IRecodable recodable = player as IRecodable;

            recodable.Record();
            recodable.Pause();
            recodable.Stop();

            Console.WriteLine(new string('-',50));

            IPlayable playable = player as IPlayable;

            playable.Play();
            playable.Pause();
            playable.Stop();            
        }
    }
}
