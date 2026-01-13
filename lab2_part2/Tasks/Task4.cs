using System;

namespace lab2Serov.Part2.Tasks
{
    public static class Task4
    {
        public static void Run()
        {
            Console.Title = "Задача 4: Сумма и произведение цифр";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 4: Сумма и произведение цифр трехзначного числа");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int number = lab2Serov.ExtendedGenerator.GenerateThreeDigitNumber();

            int hundreds = number / 100;
            int tens = (number / 10) % 10;
            int units = number % 10;

            int sum = hundreds + tens + units;
            int product = hundreds * tens * units;

            Console.WriteLine("Трехзначное число: " + number);
            Console.WriteLine();
            Console.WriteLine("Цифры числа:");
            Console.WriteLine("Сотни: " + hundreds);
            Console.WriteLine("Десятки: " + tens);
            Console.WriteLine("Единицы: " + units);
            Console.WriteLine();
            Console.WriteLine("Сумма цифр: " + sum);
            Console.WriteLine("Произведение цифр: " + product);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}