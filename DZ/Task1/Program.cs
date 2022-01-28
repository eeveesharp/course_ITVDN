using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Redactor redactor = new Redactor();

            redactor.ChooseFormat("reductor.txt");

            redactor.Create();
            redactor.Open();
            redactor.Save();
        }
    }
}
