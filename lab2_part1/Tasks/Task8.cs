using System;

namespace lab2Serov.Tasks
{
    public static class Task8
    {
        public static void Run()
        {
            Console.Title = "Задача 8: Поменять строки матрицы";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 8: Поменять местами строки матрицы");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int rows = 4;
            int cols = 4;
            int[,] matrix = ArrayGenerator.Generate2DArray(rows, cols, 0, 9);

            Console.WriteLine("Исходная матрица " + rows + "x" + cols + ":");
            ArrayGenerator.PrintMatrix(matrix);

            int row1 = ArrayGenerator.GenerateNumber(0, rows - 1);
            int row2;
            do
            {
                row2 = ArrayGenerator.GenerateNumber(0, rows - 1);
            } while (row2 == row1);

            for (int j = 0; j < cols; j++)
            {
                int temp = matrix[row1, j];
                matrix[row1, j] = matrix[row2, j];
                matrix[row2, j] = temp;
            }

            Console.WriteLine();
            Console.WriteLine("Матрица после замены строк " + row1 + " и " + row2 + ":");
            ArrayGenerator.PrintMatrix(matrix);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}