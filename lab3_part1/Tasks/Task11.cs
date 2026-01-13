using System;

namespace lab3Serov.Tasks
{
    public static class Task11
    {
        public static void Run()
        {
            Console.Title = "Задача 11: Форматированный вывод невещественных";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 11: Форматированный вывод невещественных");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int intValue = 1234567;
            long longValue = 9876543210;
            decimal decimalValue = 1234.56M;
            DateTime dateValue = DateTime.Now;

            Console.WriteLine("Целые числа:");
            Console.WriteLine("D10: " + intValue.ToString("D10"));
            Console.WriteLine("X: " + intValue.ToString("X"));

            Console.WriteLine();
            Console.WriteLine("Длинные целые:");
            Console.WriteLine("N0: " + longValue.ToString("N0"));

            Console.WriteLine();
            Console.WriteLine("Десятичные:");
            Console.WriteLine("C: " + decimalValue.ToString("C"));
            Console.WriteLine("C2: " + decimalValue.ToString("C2"));

            Console.WriteLine();
            Console.WriteLine("Дата и время:");
            Console.WriteLine("d: " + dateValue.ToString("d"));
            Console.WriteLine("D: " + dateValue.ToString("D"));
            Console.WriteLine("T: " + dateValue.ToString("T"));
            Console.WriteLine("yyyy-MM-dd: " + dateValue.ToString("yyyy-MM-dd"));

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}