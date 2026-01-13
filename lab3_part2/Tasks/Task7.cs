using System;

namespace lab3Serov.Part2.Tasks
{
    public static class Task7
    {
        public static void Run()
        {
            Console.Title = "Задача 7: Квадраты чисел";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 7: Вывод квадратов натуральных чисел");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Console.Write("Введите количество чисел: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int n) || n <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: нужно ввести положительное число!");
                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Квадраты первых " + n + " натуральных чисел:");
            Console.WriteLine();
            Console.WriteLine("n | n^2");
            Console.WriteLine("--|-----");

            for (int i = 1; i <= n; i++)
            {
                int square = i * i;
                Console.WriteLine($"{i,2} | {square,3}");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}