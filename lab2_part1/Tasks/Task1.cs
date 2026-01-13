using System;

namespace lab2Serov.Tasks
{
    public static class Task1
    {
        public static void Run()
        {
            Console.Title = "Задача 1: Сумма четных цифр числа";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 1: Сумма четных цифр числа");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int number = ArrayGenerator.GenerateNumber(100, 9999);
            Console.WriteLine("Сгенерированное число: " + number);

            int sum = 0;
            int temp = Math.Abs(number);

            while (temp > 0)
            {
                int digit = temp % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                temp /= 10;
            }

            Console.WriteLine();
            Console.WriteLine("Сумма четных цифр: " + sum);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}