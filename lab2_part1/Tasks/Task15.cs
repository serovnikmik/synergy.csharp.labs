using System;

namespace lab2Serov.Tasks
{
    public static class Task15
    {
        public static void Run()
        {
            Console.Title = "Задача 15: Среднее двух чисел";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 15: Среднее арифметическое двух чисел");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int a = ArrayGenerator.GenerateNumber(1, 100);
            int b = ArrayGenerator.GenerateNumber(1, 100);

            Console.WriteLine("Первое число: " + a);
            Console.WriteLine("Второе число: " + b);

            double average = (a + b) / 2.0;

            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое: " + average.ToString("F2"));

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}