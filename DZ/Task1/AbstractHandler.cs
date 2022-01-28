using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    abstract class AbstractHandler
    {
        protected string fileName;

        protected AbstractHandler(string fileName)
        {
            this.fileName = fileName;
        }

        public void Open() 
        {
            Console.WriteLine($"{fileName} Открыт");
        }

        public void Create() 
        {
            Console.WriteLine($"{fileName} Создан");
        }

        public void Chenge() 
        {
            Console.WriteLine($"{fileName} Изменен");
        }

        public abstract void Save();      
    }
}
