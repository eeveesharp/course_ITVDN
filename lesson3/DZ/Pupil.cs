using System;
using System.Collections.Generic;
using System.Text;

namespace DZ1
{
    class Pupil
    {
        readonly Random random = new Random();

        protected string Name { get; set; }

        public virtual void Study()
        {
            Console.WriteLine("Нормально учится");
        }

        public virtual void Read()
        {
            Console.WriteLine("Читает Пушкина");
        }

        public virtual void Write()
        {
            Console.WriteLine("Нормально пишет");
        }

        public virtual void Relax()
        {
            Console.WriteLine("В кс катает");
        }

        public string GenerationName()
        {
            int r = random.Next(1, 4);

            switch (r)
            {
                case 1:
                    {
                        Name = "Сергей Зыль";
                        break;
                    }
                case 2:
                    {
                        Name = "Влад Загорский";
                        break;
                    }
                case 3:
                    {
                        Name = "Артем Харкевич";
                        break;
                    }
                default:
                    break;
            }

            return Name;
        }
    }
}
