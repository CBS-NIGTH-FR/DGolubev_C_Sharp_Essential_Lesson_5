using System;


namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix matrix = new MyMatrix(5, 15);
            matrix.PrintMatrix(matrix.PrimaryMatrix);
            Console.WriteLine();
            matrix.CreateSecondaryMatrix(0, 0);
            matrix.PrintMatrix(matrix.SecondaryMatrix); 
            Console.ReadKey();
        }
    }
}
