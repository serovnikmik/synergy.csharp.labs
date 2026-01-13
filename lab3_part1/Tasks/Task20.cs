using System;

namespace lab3Serov.Tasks
{
    public static class Task20
    {
        public static void Run()
        {
            Console.Title = "Задача 20: Квадраты чисел";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 20: Вывод квадратов натуральных чисел");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int n = 10;

            Console.WriteLine("Квадраты первых " + n + " натуральных чисел:");
            Console.WriteLine();
            Console.WriteLine("Число | Квадрат");
            Console.WriteLine("------|--------");

            for (int i = 1; i <= n; i++)
            {
                int square = i * i;
                Console.WriteLine($"{i,5} | {square,7}");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}