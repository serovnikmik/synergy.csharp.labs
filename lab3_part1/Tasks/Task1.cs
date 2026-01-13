using System;

namespace lab3Serov.Tasks
{
    public static class Task1
    {
        public static void Run()
        {
            Console.Title = "Задача 1: Число в матрице";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 1: Сколько раз в матрице встречается число");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int[,] matrix = MathHelper.GenerateMatrix(4, 5, 1, 10);
            int targetNumber = MathHelper.GenerateNumber(1, 10);

            Console.WriteLine("Матрица 4x5:");
            MathHelper.PrintMatrix(matrix);
            Console.WriteLine();
            Console.WriteLine("Ищем число: " + targetNumber);

            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] == targetNumber)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Число " + targetNumber + " встречается " + count + " раз");

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}