using System;
using System.Collections.Generic;
using System.Text;

namespace book
{
    class Book
    {
        readonly Author Author;
        readonly Content Content;
        readonly Title Title;

        public Book(string author, string title,string content)
        {
            Author = new Author(author);
            Content = new Content(content);
            Title = new Title(title);
        }

        public void Show()
        {
            Author.Show();
            Title.Show();
            Content.Show();
        }
    }
}
