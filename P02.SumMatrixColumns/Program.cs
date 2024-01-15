namespace P02.SumMatrixColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[matrixData[0], matrixData[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] arrayRow = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arrayRow[col];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }

                Console.WriteLine(sum);
            }
                   
        }
    }
}