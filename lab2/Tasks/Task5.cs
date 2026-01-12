using System;

namespace lab2Serov.Tasks
{
    public static class Task5
    {
        public static void Run()
        {
            Console.Title = "Задача 5: Максимумы столбцов";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 5: Максимальные элементы столбцов");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int rows = 4;
            int cols = 5;
            int[,] matrix = ArrayGenerator.Generate2DArray(rows, cols, -10, 20);

            Console.WriteLine("Исходная матрица " + rows + "x" + cols + ":");
            ArrayGenerator.PrintMatrix(matrix);

            Console.WriteLine();
            Console.WriteLine("Максимальные элементы по столбцам:");

            for (int j = 0; j < cols; j++)
            {
                int max = matrix[0, j];
                for (int i = 1; i < rows; i++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
                Console.WriteLine("Столбец " + j + ": " + max);
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}