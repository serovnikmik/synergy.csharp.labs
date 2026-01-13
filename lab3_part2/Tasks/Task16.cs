using System;

namespace lab3Serov.Part2.Tasks
{
    public static class Task16
    {
        public static void Run()
        {
            Console.Title = "Задача 16: Числа Фибоначчи";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 16: Числа Фибоначчи");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Console.Write("Введите количество чисел Фибоначчи: ");
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
            Console.WriteLine("Первые " + n + " чисел Фибоначчи:");

            long a = 0, b = 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"F({i}) = {a}");
                long temp = a + b;
                a = b;
                b = temp;
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}