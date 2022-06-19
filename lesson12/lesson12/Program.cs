using System;

namespace lesson12
{
    public delegate void PressKey(); 

    class Keyboard
    {
        public event PressKey PressAKey = null;

        public event PressKey PressCKey = null;

        public void Start()
        {
            while (true)
            {
                string symbol = Console.ReadLine();

                switch (symbol.ToLower())
                {
                    case "a":
                        {
                            if (PressAKey != null)
                            {
                                PressAKey.Invoke();
                            }
                            break;
                        }
                    case "c":
                        {
                            if (PressCKey != null)
                            {
                                PressCKey.Invoke();
                            }
                            break;
                        }
                    default:
                        Console.WriteLine("Введите а или с");
                        break;
                }
            }          
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Keyboard keyboard = new Keyboard();

            keyboard.PressAKey += ShowA_Handler;

            keyboard.PressCKey += ShowC_Handler;

            keyboard.Start();
        }

        static void ShowA_Handler()
        {
            Console.WriteLine("   x  ");
            Console.WriteLine("  x x ");
            Console.WriteLine(" x x x ");
            Console.WriteLine("x     x ");
        }

        static void ShowC_Handler()
        {
            Console.WriteLine("xxxxxx");
            Console.WriteLine("x ");
            Console.WriteLine("x ");
            Console.WriteLine("xxxxxx");
        }
    }
}
