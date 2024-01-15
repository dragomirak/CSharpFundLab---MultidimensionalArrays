using System.Diagnostics.Metrics;

namespace P01.SumMatrixElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[matrixData[0], matrixData[1]];

            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] arrayRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arrayRow[col];
                    sum += arrayRow[col];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}

