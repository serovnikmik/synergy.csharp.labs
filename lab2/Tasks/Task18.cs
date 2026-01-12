using System;

namespace lab2Serov.Tasks
{
    public static class Task18
    {
        public static void Run()
        {
            Console.Title = "Задача 18: Положительные на главной диагонали";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 18: Положительные на главной диагонали");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int size = 5;
            int[,] matrix = ArrayGenerator.GenerateSquareMatrix(size, -10, 10);

            Console.WriteLine("Исходная матрица " + size + "x" + size + ":");
            ArrayGenerator.PrintMatrix(matrix);

            int count = 0;

            Console.WriteLine();
            Console.WriteLine("Элементы главной диагонали:");
            for (int i = 0; i < size; i++)
            {
                int element = matrix[i, i];
                Console.Write(element + " ");

                if (element > 0)
                {
                    count++;
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Количество положительных элементов: " + count);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}