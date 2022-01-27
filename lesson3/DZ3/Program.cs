using System;

namespace DZ3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ключ");

            string key = (Console.ReadLine()).ToString();

            DocumentWorker document = null;

            switch (key)
            {
                case "pro":
                    {
                        document = new ProDocumentWorker();
                        break;
                    }
                case "exp":
                    {
                        document = new ExpertDocumentWorker();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ключ не верный");
                        document = new DocumentWorker();
                        break;
                    }
            }

            document.OpenDocument();
            document.EditDocument();
            document.SaveDocument();
        }
    }
}
