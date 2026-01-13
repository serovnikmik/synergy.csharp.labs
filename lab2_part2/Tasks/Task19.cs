using System;

namespace lab2Serov.Part2.Tasks
{
    public static class Task19
    {
        public static void Run()
        {
            Console.Title = "Задача 19: Вычисление f(x)";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 19: Вычисление f(x) в зависимости от x");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Функция:");
            Console.WriteLine("  x^2,          если x < 0");
            Console.WriteLine("  x + 1,       если 0 ≤ x ≤ 5");
            Console.WriteLine("  2x - 1,      если x > 5");
            Console.WriteLine();

            Random random = new Random();
            double x = random.Next(-10, 15) + random.NextDouble();

            double result;

            if (x < 0)
            {
                result = x * x;
            }
            else if (x >= 0 && x <= 5)
            {
                result = x + 1;
            }
            else
            {
                result = 2 * x - 1;
            }

            Console.WriteLine("x = " + x.ToString("F2"));
            Console.WriteLine("f(x) = " + result.ToString("F2"));

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}