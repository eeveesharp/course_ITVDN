using System;

namespace DZ1
{
    class Program
    {
        static void Main(string[] args)
        {

            BadPupil badPupil = new BadPupil();

            ExcelentPupil excelentPupil = new ExcelentPupil();

            GoodPupil goodPupil = new GoodPupil();

            ClassRoom classRoom = new ClassRoom(excelentPupil, goodPupil);

            classRoom.Study();

            Console.WriteLine(new string('-', 30));

            classRoom.Read();

            Console.WriteLine(new string('-', 30));

            classRoom.Write();

            Console.WriteLine(new string('-', 30));

            classRoom.Relax();
        }
    }
}
