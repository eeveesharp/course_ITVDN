using System;
using System.Collections.Generic;
using System.Text;

namespace book
{
    class Content
    {
        public string TextContent { get; set; }

        public Content(string textContent)
        {
            TextContent = textContent;
        }

        public void Show()
        {
            Console.WriteLine("Контент:" + TextContent);
        }
    }
}
