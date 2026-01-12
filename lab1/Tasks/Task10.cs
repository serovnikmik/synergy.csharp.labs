using System;

namespace Lab1Serov.Tasks
{
    public static class Task10
    {
        public static void Run()
        {
            Console.Title = "Задача 10: Сумма и разность";
            Console.Clear();

            Console.WriteLine("========================================");
            Console.WriteLine("ЗАДАЧА 10: Сумма и разность двух чисел");
            Console.WriteLine("========================================");
            Console.WriteLine();

            Console.Write("Введите первое число: ");
            string input1 = Console.ReadLine();

            Console.Write("Введите второе число: ");
            string input2 = Console.ReadLine();

            bool isNumber1 = double.TryParse(input1, out double num1);
            bool isNumber2 = double.TryParse(input2, out double num2);

            if (!isNumber1 || !isNumber2)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: оба значения должны быть числами!");
                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата...");
                Console.ReadKey();
                return;
            }

            double sum = num1 + num2;
            double difference1 = num1 - num2;
            double difference2 = num2 - num1;

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("РЕЗУЛЬТАТ:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Первое число: " + num1);
            Console.WriteLine("Второе число: " + num2);
            Console.WriteLine();
            Console.WriteLine("Сумма чисел: " + sum);
            Console.WriteLine("Разность (первое - второе): " + difference1);
            Console.WriteLine("Разность (второе - первое): " + difference2);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}