using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class DOCHandler : AbstractHandler
    {
        public DOCHandler(string fileName)
            :base(fileName)
        {

        }

        public override void Save()
        {
            Console.WriteLine($"{fileName} сохранен в формате .doc");
        }
    }
}
