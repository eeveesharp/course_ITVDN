using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Article
    {
        public string Name { get; set; }

        public string NameShop { get; set; }

        public double Price { get; set; }

        public Article(string name,string nameShop,double price)
        {
            Name = name;
            NameShop = nameShop;
            Price = price;
        }

        public string GetInfo()
        {
            return $"Название товара:{Name}\n" +
                $"Название магазина:{NameShop}\n" +
                $"Цена:{Price}$";
        }
    }
}
