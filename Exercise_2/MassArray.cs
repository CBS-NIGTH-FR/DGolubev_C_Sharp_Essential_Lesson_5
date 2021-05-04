using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class MassArray
    {
        public int[] Number { get; set; }
        Random random_number;

        public int[] InitializationMass(int number)
        {
            Number = new int[number];
            return Number;
        }

        public void AddNumber()
        {
            for (int i = 0; i < Number.Length; i++)
            {
                random_number = new Random();
                int a = random_number.Next(100);

                if (!Number.Contains(a))
                {
                    Number[i] = a;
                    Console.WriteLine(Number[i]);
                }
                else i--;
            }
        }

        public int MaxValue(int[] mass_array)
        {
            int max_value = mass_array[0];
            foreach (int item in Number)
            {
                if(item > max_value)
                {
                    max_value = item;
                }
            }
            return max_value;
        }

        public int MinValue(int[] mass_array)
        {
            int min_value = mass_array[0];
            foreach (int item in Number)
            {
                if (item < min_value)
                {
                    min_value = item;
                }
            }
            return min_value;
        }
        
        public int SumValue(int[] mass_array)
        {
            int value = 0;
            foreach (int item in Number)
            {
                value += item;
            }
            return value;
        }

        public double ArithmeticMean(int[] mass_array)
        {
            double value = 0;
            foreach (int item in Number)
            {
                value += item;
            }
            return value/Number.Length; 
        }

        public List<int> OddValues(int[] mass_array)
        {
            List<int> value = new List<int>();
            string val;
            foreach (int item in Number)
            {
                if(item%2 != 0)
                {
                    value.Add(item);
                }
            }
            return value;
        }
    }
}
