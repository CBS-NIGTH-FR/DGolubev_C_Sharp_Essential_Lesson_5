using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MassArray array = new MassArray();
            array.Number = array.InitializationMass(5);
            array.AddNumber();
            int max = array.MaxValue(array.Number);
            int min = array.MinValue(array.Number);
            int sum = array.SumValue(array.Number);
            double mean = array.ArithmeticMean(array.Number);
            List<int> odd = array.OddValues(array.Number);
            var str = string.Join(", ", odd.ToArray());
            Console.WriteLine();
            Console.WriteLine($"Максимальное значение - {max}\nМинимальное значение - {min}\nСумма всех элементов - {sum}\nСреднее арифметическое - {mean}");
            Console.WriteLine($"Нечетные элементы - {str}");
            Console.ReadKey();
        }
    }
}
