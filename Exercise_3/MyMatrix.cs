using System;
using System.Collections;

namespace Exercise_3
{
    class MyMatrix: IEnumerable
    {
        public int[,] PrimaryMatrix { get; private set; }
        public int[,] SecondaryMatrix { get; private set; }

        Random random;

        public MyMatrix(int row, int column)
        {
            PrimaryMatrix = new int[row, column];
            AddNumber();
        }

        public void AddNumber()
        {
            random = new Random();
            for (int i = 0; i < PrimaryMatrix.GetLength(0); i++)
            {
                for (int y = 0; y < PrimaryMatrix.GetLength(1); y++)
                {
                    PrimaryMatrix[i, y] = random.Next(100);
                }
            }
        }

        public int[,] CreateSecondaryMatrix(int row, int column)
        {
           SecondaryMatrix = new int[row, column];
            if (row <= 0 || column <= 0)
            {
                Console.WriteLine("Не возможно отбразить 0 столбцов или 0 строк, введите новые значения");
                Console.WriteLine("Колличество строк");
                row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Колличество столбцов");
                column = Convert.ToInt32(Console.ReadLine());
                CreateSecondaryMatrix(row, column);
            }
            for (int i = 0; i < Math.Min(PrimaryMatrix.GetLength(0), row); i++)
            {
                for (int j = 0; j < Math.Min(PrimaryMatrix.GetLength(1), column); j++)
                {
                    SecondaryMatrix[i, j] = PrimaryMatrix[i, j];
                }
            }
            if (row > PrimaryMatrix.GetLength(0))
            {
                for (int i = PrimaryMatrix.GetLength(0); i < SecondaryMatrix.GetLength(0); i++)
                {
                    for (int j =0; j < SecondaryMatrix.GetLength(1); j++)
                    {
                        SecondaryMatrix[i, j] = random.Next(100);
                    }
                }
            }
            if (column > PrimaryMatrix.GetLength(1))
            {
                for (int i = 0; i < Math.Min(row, PrimaryMatrix.GetLength(0)); i++)
                {
                    for (int j = PrimaryMatrix.GetLength(1); j < column; j++)
                    {
                        SecondaryMatrix[i, j] = random.Next(100);
                    }
                }
            }
            return SecondaryMatrix;
        }

        public void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    Console.Write("{0, 3}", matrix[i, y]);
                }
                Console.WriteLine();
            }
        }

        public IEnumerator GetEnumerator()
        {
            return PrimaryMatrix.GetEnumerator();
        }
               
    }
}
