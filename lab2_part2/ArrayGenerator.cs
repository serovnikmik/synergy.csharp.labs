using System;

namespace lab2Serov
{
    public static class ArrayGenerator
    {
        private static Random random = new Random();

        public static int GenerateNumber(int min, int max)
        {
            return random.Next(min, max + 1);
        }

        public static int[] Generate1DArray(int size, int minValue, int maxValue)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(minValue, maxValue + 1);
            }
            return array;
        }

        public static int[,] Generate2DArray(int rows, int cols, int minValue, int maxValue)
        {
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(minValue, maxValue + 1);
                }
            }
            return matrix;
        }

        public static string ArrayToString(int[] array)
        {
            return "[" + string.Join(", ", array) + "]";
        }

        public static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
        }
    }
}