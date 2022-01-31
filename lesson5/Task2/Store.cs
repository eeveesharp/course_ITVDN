using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Store
    {
        private Article[] articles;

        public Store(int size)
        {
            articles = new Article[size];
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < articles.Length)
                {
                    return articles[index].GetInfo();
                }

                return "Неверный индекс";
            }
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < articles.Length; i++)
                {
                    if (articles[i].Name.ToLower() == index.ToLower())
                    {
                        return articles[i].GetInfo();
                    }
                }

                return "Неверный индекс";
            }
        }

        public void AddProduct(Article article,int index)
        {
            if (index >= 0 && index < articles.Length)
            {
                articles[index] = article;
            }
            else
            {
                Console.WriteLine("Выход за пределы");
            }
        }
    }
}
