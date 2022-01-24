using System;
using System.Collections.Generic;
using System.Text;

namespace book
{
    class Title
    {
        public string TextTitle { get; set; }

        public Title(string textTitle)
        {
            TextTitle = textTitle;
        }

        public void Show()
        {
            Console.WriteLine("Заголовок:" + TextTitle);
        }
    }
}
