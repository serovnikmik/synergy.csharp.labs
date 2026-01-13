using System;

namespace lab3Serov.Tasks
{
    public static class Task8
    {
        public static void Run()
        {
            Console.Title = "Задача 8: Факториал";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 8: Вычисление факториала");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int n = MathHelper.GenerateNumber(1, 10);

            int factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("n = " + n);
            Console.WriteLine(n + "! = " + factorial);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}