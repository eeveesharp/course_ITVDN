using System;
using System.Collections.Generic;
using System.Text;

namespace DZ1
{
    class BadPupil:Pupil
    {
        public BadPupil()
        {
            Name = "Сергей Зыль";
        }
        public override void Study()
        {
            Console.WriteLine($"{Name}:Одни тройки");
        }

        public override void Read()
        {
            Console.WriteLine($"{Name}:Не читает вовсе");
        }

        public override void Write()
        {
            Console.WriteLine($"{Name}:Пишет не понятно");
        }

        public override void Relax()
        {
            Console.WriteLine($"{Name}:Пиво под падиком");
        }     
    }
}
