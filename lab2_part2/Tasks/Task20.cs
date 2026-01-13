using System;

namespace lab2Serov.Part2.Tasks
{
    public static class Task20
    {
        public static void Run()
        {
            Console.Title = "Задача 20: Переворот числа";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 20: Переворот числа");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int number = lab2Serov.ExtendedGenerator.GenerateNumber(1000, 99999);

            Console.WriteLine("Исходное число: " + number);

            int reversed = 0;
            int temp = Math.Abs(number);
            int original = temp;

            while (temp > 0)
            {
                int digit = temp % 10;
                reversed = reversed * 10 + digit;
                temp /= 10;
            }

            if (number < 0)
            {
                reversed = -reversed;
            }

            Console.WriteLine();
            Console.WriteLine("Перевернутое число: " + reversed);

            Console.WriteLine();
            Console.WriteLine("Проверка:");
            Console.WriteLine("Исходное: " + original);
            Console.WriteLine("Перевернутое: " + Math.Abs(reversed));

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}