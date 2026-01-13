using System;

namespace lab2Serov.Tasks
{
    public static class Task17
    {
        public static void Run()
        {
            Console.Title = "Задача 17: Сумма и произведение матрицы";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 17: Сумма и произведение матрицы");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int rows = 3;
            int cols = 3;
            int[,] matrix = ArrayGenerator.Generate2DArray(rows, cols, 1, 5);

            Console.WriteLine("Исходная матрица " + rows + "x" + cols + ":");
            ArrayGenerator.PrintMatrix(matrix);

            int sum = 0;
            long product = 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum += matrix[i, j];
                    product *= matrix[i, j];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Сумма всех элементов: " + sum);
            Console.WriteLine("Произведение всех элементов: " + product);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}