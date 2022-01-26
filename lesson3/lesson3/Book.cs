using System;
using System.Collections.Generic;
using System.Text;

namespace lesson3
{
    class Book
    {
        public Author author;
        public Content content;

        //public Book(Author author, string content)
        //{
        //    this.author = author;
        //    this.content = new Content(content);
        //}

        public void Show()
        {
            author = new Author();
            author.Name = "ffgd";
            author.Show();
        }
    }
}
