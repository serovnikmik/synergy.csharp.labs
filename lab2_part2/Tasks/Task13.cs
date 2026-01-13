using System;

namespace lab2Serov.Part2.Tasks
{
    public static class Task13
    {
        public static void Run()
        {
            Console.Title = "Задача 13: Дни в году";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 13: Количество дней в году");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int year = lab2Serov.ExtendedGenerator.GenerateYear();

            bool isLeapYear = false;

            if (year % 400 == 0)
            {
                isLeapYear = true;
            }
            else if (year % 100 == 0)
            {
                isLeapYear = false;
            }
            else if (year % 4 == 0)
            {
                isLeapYear = true;
            }

            int daysInYear = isLeapYear ? 366 : 365;

            Console.WriteLine("Год: " + year);
            Console.WriteLine();
            Console.WriteLine("Результат:");
            Console.WriteLine("Високосный год: " + (isLeapYear ? "Да" : "Нет"));
            Console.WriteLine("Количество дней: " + daysInYear);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}