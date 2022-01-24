using System;
using System.Collections.Generic;
using System.Text;

namespace book
{
    class Author
    {
        public string NameAuthor { get; set; }

        public Author(string name)
        {
            NameAuthor = name;
        }

        public void Show()
        {
            Console.WriteLine("Имя автора:" + NameAuthor);
        }
    }
}
