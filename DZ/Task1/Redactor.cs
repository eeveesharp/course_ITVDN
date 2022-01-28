using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Redactor
    {
        AbstractHandler handler;

        public void ChooseFormat(string fileName)
        {
            string format = fileName.Substring(fileName.Length - 4);

            switch (format)
            {
                case ".txt":
                    {
                        handler = new TXTHandler(fileName);
                        break;
                    }
                case ".doc":
                    {
                        handler = new DOCHandler(fileName);
                        break;
                    }
                case ".xml":
                    {
                        handler = new XMLHandler(fileName);
                        break;
                    }
                default:
                    Console.WriteLine("ХЗ что за формат");
                    break;
            }
        }

        public void Open()
        {
            handler.Open();
        }

        public void Chenge()
        {
            handler.Chenge();
        }

        public void Save()
        {
            handler.Save();
        }

        public void Create()
        {
            handler.Create();
        }
    }
}
