using System;
using System.Collections.Generic;
using System.Text;

namespace lesson3
{
    class Author
    {
        public string Name { get; set; }
        public string SName { get; private set; }

        public Author()
        {
            
        }

        public void Show()
        {
            Console.WriteLine($"Name:{Name}");
        }
    }
}
