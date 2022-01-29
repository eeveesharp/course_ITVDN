using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Player : IPlayable, IRecodable
    {
        public void Pause()
        {
            Console.WriteLine("Пауза");
        }

        public void Play()
        {
            Console.WriteLine("Проигрование");
        }

        public void Record()
        {
            Console.WriteLine("Запись");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Завершение проигрования");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Завершение записи");
        }
    }
}
