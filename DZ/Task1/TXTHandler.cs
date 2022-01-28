using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class TXTHandler : AbstractHandler
    {
        public TXTHandler(string fileName)
            :base(fileName)
        {

        }

        public override void Save()
        {
            Console.WriteLine($"{fileName} сохранен в формате .txt");
        }
    }
}
