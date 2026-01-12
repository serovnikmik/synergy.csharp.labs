using System;

namespace lab2Serov.Tasks
{
    public static class Task9
    {
        public static void Run()
        {
            Console.Title = "Задача 9: Наибольший по модулю";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 9: Наибольший по модулю элемент");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int rows = 3;
            int cols = 4;
            int[,] matrix = ArrayGenerator.Generate2DArray(rows, cols, -15, 15);

            Console.WriteLine("Исходная матрица " + rows + "x" + cols + ":");
            ArrayGenerator.PrintMatrix(matrix);

            int maxAbsValue = Math.Abs(matrix[0, 0]);
            int maxRow = 0;
            int maxCol = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int absValue = Math.Abs(matrix[i, j]);
                    if (absValue > maxAbsValue)
                    {
                        maxAbsValue = absValue;
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Наибольший по модулю элемент:");
            Console.WriteLine("Значение: " + matrix[maxRow, maxCol]);
            Console.WriteLine("Позиция: [" + maxRow + ", " + maxCol + "]");
            Console.WriteLine("Модуль: " + maxAbsValue);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}