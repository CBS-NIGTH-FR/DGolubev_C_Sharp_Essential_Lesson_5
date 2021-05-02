using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store(3);
            store.AddProduct(new Article("Book", "MackMilan", 20.50), 0);
            store.AddProduct(new Article("Apple", "Digits", 5.90), 1);
            store.AddProduct(new Article("Coca - Cola", "USA Product", 7.25), 2);

            Console.WriteLine(store["Apple"]);
            Console.WriteLine(new string('-', 50));

            Console.WriteLine(store["Dog"]);
            Console.WriteLine(new string('-', 50));

            Console.WriteLine(store[2]);
            Console.WriteLine(new string('-', 50));

            store.Show();
            Console.WriteLine(new string('-', 50));

            store.Sort();
            store.Show();
            Console.WriteLine(new string('-', 50));

            Console.ReadKey();
        }
    }
}
