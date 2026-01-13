using System;

namespace lab3Serov.Tasks
{
    public static class Task15
    {
        public static void Run()
        {
            Console.Title = "Задача 15: Извлечение цифр";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 15: Извлечение цифр числа");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int number = MathHelper.GenerateNumber(1000, 9999);

            Console.WriteLine("Исходное число: " + number);
            Console.WriteLine();
            Console.WriteLine("Цифры числа:");

            int temp = number;
            while (temp > 0)
            {
                int digit = temp % 10;
                Console.WriteLine(digit);
                temp /= 10;
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}