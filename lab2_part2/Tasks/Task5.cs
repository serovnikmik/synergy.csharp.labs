using System;

namespace lab2Serov.Part2.Tasks
{
    public static class Task5
    {
        public static void Run()
        {
            Console.Title = "Задача 5: Таблица значений функции";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 5: Таблица значений функции");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Функция: f(x) = x^2 - 2x + 1");
            Console.WriteLine();

            Console.WriteLine(" x  |  f(x)");
            Console.WriteLine("----|-------");

            for (double x = -2; x <= 2; x += 0.5)
            {
                double y = lab2Serov.ExtendedGenerator.Function1(x);
                Console.WriteLine($"{x,4:F1} | {y,6:F2}");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}