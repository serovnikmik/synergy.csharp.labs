using System;

namespace lab3Serov.Part2.Tasks
{
    public static class Task6
    {
        public static void Run()
        {
            Console.Title = "Задача 6: Сумма и произведение цифр";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 6: Сумма и произведение цифр числа");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int number = StringArrayHelper.GenerateNumber(100, 99999);

            Console.WriteLine("Число: " + number);

            int sum = 0;
            int product = 1;
            int temp = Math.Abs(number);
            int digitCount = 0;

            Console.WriteLine();
            Console.WriteLine("Цифры числа:");

            while (temp > 0)
            {
                int digit = temp % 10;
                Console.WriteLine(digit);
                sum += digit;
                product *= digit;
                digitCount++;
                temp /= 10;
            }

            Console.WriteLine();
            Console.WriteLine("Количество цифр: " + digitCount);
            Console.WriteLine("Сумма цифр: " + sum);
            Console.WriteLine("Произведение цифр: " + product);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}