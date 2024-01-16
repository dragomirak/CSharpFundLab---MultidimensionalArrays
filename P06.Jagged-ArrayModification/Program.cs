namespace P06.Jagged_ArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                jaggedArray[row] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            }

            while (true)
            {
                string[] tokens = Console.ReadLine().Split(" ").ToArray();
                string command = tokens[0];

                if (command == "END")
                {
                    break;
                }

                int rowIndex = int.Parse(tokens[1]);
                int colIndex = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (command == "Add")
                {
                    if (rowIndex < 0 || rowIndex >= jaggedArray.Length
                        || colIndex < 0 || colIndex >= jaggedArray[rowIndex].Length)
                    {
                        Console.WriteLine("Invalid coordinates");
                        continue;
                    }
                    else
                    {
                        jaggedArray[rowIndex][colIndex] += value;
                    }
                }
                else if (command == "Subtract")
                {
                    if (rowIndex < 0 || rowIndex >= jaggedArray.Length
                        || colIndex < 0 || colIndex >= jaggedArray[rowIndex].Length)
                    {
                        Console.WriteLine("Invalid coordinates");
                        continue;
                    }
                    else
                    {
                        jaggedArray[rowIndex][colIndex] -= value;
                    }
                }
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}