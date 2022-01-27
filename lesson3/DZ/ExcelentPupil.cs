using System;
using System.Collections.Generic;
using System.Text;

namespace DZ1
{
    class ExcelentPupil : Pupil
    {
        public ExcelentPupil()
        {
            Name = "Артем Харкевич";
        }
        public override void Study()
        {         
            Console.WriteLine($"{Name}:Слишком отлично учится");
        }

        public override void Read()
        {
            Console.WriteLine($"{Name}:Читает каждую свободную минуту по 150+ листов");
        }

        public override void Write()
        {
            Console.WriteLine($"{Name}:Подчерк калиграфический");
        }

        public override void Relax()
        {
            Console.WriteLine($"{Name}:Настолько отличный что не отдыхает,постоянно учится");
        }
    }
}
