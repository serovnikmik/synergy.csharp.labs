using System;
using System.Collections.Generic;

namespace Lab1Serov.Tasks
{
    public static class Task4
    {
        public static void Run()
        {
            Console.Title = "Задача 4: Месяц и дни";
            Console.Clear();

            Console.WriteLine("========================================");
            Console.WriteLine("ЗАДАЧА 4: Месяц и количество дней");
            Console.WriteLine("========================================");
            Console.WriteLine();
            Console.WriteLine("Примечание: год считается невисокосным");
            Console.WriteLine("(февраль - 28 дней)");
            Console.WriteLine();

            var monthData = new Dictionary<string, int>
            {
                { "january", 31 },
                { "february", 28 },
                { "march", 31 },
                { "april", 30 },
                { "may", 31 },
                { "june", 30 },
                { "july", 31 },
                { "august", 31 },
                { "september", 30 },
                { "october", 31 },
                { "november", 30 },
                { "december", 31 }
            };

            Console.WriteLine("Введите название месяца на английском:");
            Console.WriteLine("(регистр не имеет значения)");
            Console.Write(">>> ");

            string inputMonth = Console.ReadLine();
            string monthKey = inputMonth.ToLower();

            if (!monthData.ContainsKey(monthKey))
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: некорректное название месяца!");
                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата...");
                Console.ReadKey();
                return;
            }

            int correctDays = monthData[monthKey];

            Console.WriteLine();
            Console.WriteLine("Месяц: " + FirstLetterUpperCase(monthKey));
            Console.WriteLine("Ожидаемое количество дней: " + correctDays);
            Console.WriteLine();
            Console.Write("Введите количество дней: ");

            string inputDays = Console.ReadLine();
            int userDays;

            bool isNumber = int.TryParse(inputDays, out userDays);
            if (!isNumber)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: нужно ввести число!");
                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("РЕЗУЛЬТАТ И ПРОВЕРКА:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Месяц: " + FirstLetterUpperCase(monthKey));
            Console.WriteLine("Ваш ввод: " + userDays + " дней");
            Console.WriteLine("Корректно: " + correctDays + " дней");
            Console.WriteLine();

            if (userDays == correctDays)
            {
                Console.WriteLine("ВЕРНО! Количество дней совпадает.");
            }
            else
            {
                Console.WriteLine("ОШИБКА! Количество дней неверное.");
            }

            if (monthKey == "february")
            {
                Console.WriteLine();
                Console.WriteLine("--- Информация о феврале ---");
                Console.WriteLine("В невисокосном году: 28 дней");
                Console.WriteLine("В високосном году: 29 дней");
                Console.WriteLine("Примечание: программа считает год невисокосным");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }

        private static string FirstLetterUpperCase(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            string firstChar = text[0].ToString().ToUpper();
            string restOfText = text.Substring(1);

            return firstChar + restOfText;
        }
    }
}