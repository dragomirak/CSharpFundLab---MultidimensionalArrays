using System.Data.Common;

namespace P03.PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixData = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixData, matrixData];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] arrayRow = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arrayRow[col];
                }
            }

            int sumPrimaryDiagonal = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sumPrimaryDiagonal += matrix[i, i];
            }

            Console.WriteLine(sumPrimaryDiagonal);
        }
    }
}