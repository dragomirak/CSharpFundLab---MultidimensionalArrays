using System;

namespace P05.SquareWithMaxSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = matrixData[0];
            int cols = matrixData[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] rowData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int maxSum = int.MinValue;
            int rowIndex = 0;
            int colIndex = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                int sum = 0;
                for (int col = 0; col < cols - 1; col++)
                {
                    sum = matrix[row, col] + matrix[row, col+1] + matrix[row+1, col] + matrix[row+1, col+1];

                    if (sum > maxSum)
                    {
                        maxSum = sum; 
                        rowIndex = row; 
                        colIndex = col;
                    }
                }
            }

            Console.Write($"{matrix[rowIndex, colIndex]} {matrix[rowIndex, colIndex+1]}");
            Console.WriteLine();
            Console.Write($"{matrix[rowIndex+1, colIndex]} {matrix[rowIndex + 1, colIndex + 1]}");
            Console.WriteLine();
            Console.WriteLine(maxSum);

        }
    }
}