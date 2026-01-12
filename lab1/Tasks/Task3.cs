using System;

namespace Lab1Serov.Tasks
{
    public static class Task3
    {
        public static void Run()
        {
            Console.Title = "Задача 3: Дата";
            Console.Clear();

            Console.WriteLine("========================================");
            Console.WriteLine("ЗАДАЧА 3: Дата (день недели, дата, месяц)");
            Console.WriteLine("========================================\n");

            string[] validDays = { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };
            string[] validMonths = { "january", "february", "march", "april", "may", "june",
                                     "july", "august", "september", "october", "november", "december" };

            Console.WriteLine("Введите день недели НА АНГЛИЙСКОМ (например: Monday)");
            Console.WriteLine("Регистр неважен (можно monday или MONDAY)");
            Console.Write(">>> ");

            string dayOfWeek = Console.ReadLine().ToLower();

            bool isValidDay = false;
            foreach (string validDay in validDays)
            {
                if (dayOfWeek == validDay)
                {
                    isValidDay = true;
                    break;
                }
            }

            if (!isValidDay)
            {
                Console.WriteLine("\nОшибка: некорректный день недели!");
                Console.WriteLine("Допустимые значения: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday");
                Console.WriteLine("\n[Нажмите любую клавишу для возврата...]");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();

            Console.WriteLine("Введите месяц НА АНГЛИЙСКОМ (например: January)");
            Console.WriteLine("Регистр неважен (можно january или JANUARY)");
            Console.Write(">>> ");

            string month = Console.ReadLine().ToLower();

            bool isValidMonth = false;
            foreach (string validMonth in validMonths)
            {
                if (month == validMonth)
                {
                    isValidMonth = true;
                    break;
                }
            }

            if (!isValidMonth)
            {
                Console.WriteLine("\nОшибка: некорректный месяц!");
                Console.WriteLine("Допустимые значения: January, February, March, April, May, June,");
                Console.WriteLine("July, August, September, October, November, December");
                Console.WriteLine("\n[Нажмите любую клавишу для возврата...]");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();

            Console.WriteLine("Введите число (день месяца) от 1 до 31");
            Console.WriteLine("Примечание: проверки на корректное число нет,");
            Console.WriteLine("программа вам верит, что вы ввели корректно");
            Console.Write(">>> ");

            string input = Console.ReadLine();

            if (!int.TryParse(input, out int day))
            {
                Console.WriteLine("\nОшибка: нужно ввести число!");
                Console.WriteLine("\n[Нажмите любую клавишу для возврата...]");
                Console.ReadKey();
                return;
            }

            if (day < 1 || day > 31)
            {
                Console.WriteLine("\nОшибка: число должно быть от 1 до 31!");
                Console.WriteLine("\n[Нажмите любую клавишу для возврата...]");
                Console.ReadKey();
                return;
            }

            string formattedDay = char.ToUpper(dayOfWeek[0]) + dayOfWeek.Substring(1);
            string formattedMonth = char.ToUpper(month[0]) + month.Substring(1);

            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("РЕЗУЛЬТАТ:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Сегодня: {formattedDay}, {day} {formattedMonth}");

            Console.WriteLine("\n[Нажмите любую клавишу для возврата...]");
            Console.ReadKey();
        }
    }
}