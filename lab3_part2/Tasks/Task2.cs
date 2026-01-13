using System;

namespace lab3Serov.Part2.Tasks
{
    public static class Task2
    {
        public static void Run()
        {
            Console.Title = "Задача 2: Сумма рядов";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 2: Сумма элементов различных рядов");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int n = 10;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;

            Console.WriteLine("n = " + n);
            Console.WriteLine();
            Console.WriteLine("1. Сумма 1 + 2 + 3 + ... + n");
            for (int i = 1; i <= n; i++) sum1 += i;
            Console.WriteLine("Сумма = " + sum1);

            Console.WriteLine();
            Console.WriteLine("2. Сумма 1^2 + 2^2 + 3^2 + ... + n^2");
            for (int i = 1; i <= n; i++) sum2 += i * i;
            Console.WriteLine("Сумма = " + sum2);

            Console.WriteLine();
            Console.WriteLine("3. Сумма 1 + 1/2 + 1/3 + ... + 1/n");
            for (int i = 1; i <= n; i++) sum3 += 1.0 / i;
            Console.WriteLine("Сумма = " + sum3.ToString("F4"));

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}