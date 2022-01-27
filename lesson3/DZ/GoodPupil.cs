using System;
using System.Collections.Generic;
using System.Text;

namespace DZ1
{
    class GoodPupil : Pupil
    {
        public GoodPupil()
        {
            Name = "Влад Загорский";
        }
        public override void Study()
        {
            Console.WriteLine($"{Name}:Хорошист");
        }

        public override void Read()
        {
            Console.WriteLine($"{Name}:Читает когда задают");
        }

        public override void Write()
        {
            Console.WriteLine($"{Name}:Пишет понятно");
        }

        public override void Relax()
        {
            Console.WriteLine($"{Name}:Игарет в доту");
        }
    }
}
