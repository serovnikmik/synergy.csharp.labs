using System;

namespace lab3Serov.Tasks
{
    public static class Task19
    {
        public static void Run()
        {
            Console.Title = "Задача 19: Сумма и произведение цифр";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 19: Сумма и произведение цифр числа");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int number = MathHelper.GenerateNumber(100, 999);

            int digit1 = number / 100;
            int digit2 = (number / 10) % 10;
            int digit3 = number % 10;

            int sum = digit1 + digit2 + digit3;
            int product = digit1 * digit2 * digit3;

            Console.WriteLine("Число: " + number);
            Console.WriteLine();
            Console.WriteLine("Цифры: " + digit1 + ", " + digit2 + ", " + digit3);
            Console.WriteLine("Сумма цифр: " + sum);
            Console.WriteLine("Произведение цифр: " + product);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}