using System;


namespace Exercise_4
{
    class Store
    {
        private Article[] articles;

        public Store(int size)
        {
            articles = new Article[Math.Abs(size)]; //Супер!
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < articles.Length) return articles[index].ProductInfo();
                return "Попытка обращения за пределы массива";
            }
        }

        public void AddProduct(Article value, int index)
        {
            if (index >= 0 && index < articles.Length) articles[index] = value;
            else Console.WriteLine("Попытка записи за пределы массива");
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < articles.Length; i++)
                {
                    if (articles[i].ProductName == index)
                    {
                        return articles[i].ProductInfo();
                    }
                }
                return string.Format("\"{0}\" нет в наличии.", index);
            }
        }

        public void Show()
        {
            for (int i = 0; i < articles.Length; i++)
            {
                Console.WriteLine(articles[i].ProductInfo());
            }
        }

        public void Sort()
        {
            for (int i = 0; i < articles.Length - 1; i++)
            {
                for (int j = 0; j < articles.Length - 1; j++)
                {
                    if (articles[i].ProductPrice <= articles[j].ProductPrice)
                    {
                        Article g = articles[i]; //Отлично, что применили пузырьковую сортировку
                        articles[i] = articles[j];
                        articles[j] = g;
                    }

                }

            }
        }
    }
}
