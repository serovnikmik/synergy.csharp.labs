using System;

namespace lab2Serov.Part2.Tasks
{
    public static class Task12
    {
        public static void Run()
        {
            Console.Title = "Задача 12: Цифры и знак числа";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 12: Цифры в числе и его знак");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int number = lab2Serov.ExtendedGenerator.GenerateNumber(-99999, 99999);

            Console.WriteLine("Исходное число: " + number);

            string sign = "ноль";
            if (number > 0) sign = "положительное";
            else if (number < 0) sign = "отрицательное";

            int digitCount = 0;
            int temp = Math.Abs(number);

            if (temp == 0)
            {
                digitCount = 1;
            }
            else
            {
                while (temp > 0)
                {
                    digitCount++;
                    temp /= 10;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Анализ числа:");
            Console.WriteLine("Знак: " + sign);
            Console.WriteLine("Количество цифр: " + digitCount);
            Console.WriteLine("Модуль числа: " + Math.Abs(number));

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}