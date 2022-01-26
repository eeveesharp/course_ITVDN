using System;
using System.Collections.Generic;
using System.Text;

namespace lesson3
{
    class Content
    {
        public string Text { get; set; }

        public Content(string text)
        {
            Text = text;
        }

        public void Show()
        {
            Console.WriteLine($"Content:{Text}");
        }
    }
}
