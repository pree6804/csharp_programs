using System;

namespace interviewc_
{
    class step5
    {
        public static void Main(string[] args)
        {


            // types of array itialization
            int[] evennumbers = new int[] { 2, 4, 6, 8, 10, 12 };
            int[] even = new int[9];
            int[] evennumbersshortcut = { 2, 4, 6, 8, 10, 12 };
            // types of array
            int[,] matrix = { { 1, 2, 3, }, { 2, 4, 5, }, { 3, 5, 6, } };
            int[,] mat = new int[3, 2];

            // Get the dimensions
            int rows = mat.GetLength(0); // 3
            int cols = mat.GetLength(1);  // 2

            Console.WriteLine($"Enter {rows * cols} integer elements for the {rows}x{cols} matrix:");

            // Outer loop for rows
            for (int i = 0; i < rows; i++)
            {
                // Inner loop for columns
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i}, {j}]: ");

                    string input = Console.ReadLine();
                    mat[i, j] = int.Parse(input);
                }
            }
        }

    }

}

