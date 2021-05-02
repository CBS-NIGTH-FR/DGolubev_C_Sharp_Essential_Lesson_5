using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Article
    {
        public string ProductName { get; private set; }
        private string ShopName { get; set; }
        private double product_price;

        public double ProductPrice
        {
            set
            {
                if (value >= 0) product_price = value;
                else Console.WriteLine("Стоимость не может быть отрицательной");
            }
            get
            {
                return product_price;
            }
        }

        public Article(string product_name)
        {
            ProductName = product_name;
        }

        public Article(string product_name, string shop_name, double product_price)
        {
            ProductName = product_name;
            ShopName = shop_name;
            ProductPrice = product_price;
        }
        
        public string ProductInfo()
        {
             return string.Format($"{ProductName} из {ShopName} стоимость: {ProductPrice} UAH");
        }
        
    }  
}
