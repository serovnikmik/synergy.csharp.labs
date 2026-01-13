using System;

namespace lab3Serov.Tasks
{
    public static class Task6
    {
        public static void Run()
        {
            Console.Title = "Задача 6: Правильное окончание";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 6: Правильное окончание к числу");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Введите количество:");
            Console.Write(">>> ");

            string input = Console.ReadLine();

            if (!int.TryParse(input, out int number) || number < 0)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: нужно ввести положительное число!");
                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Результаты:");
            Console.WriteLine();

            Console.WriteLine(GetPluralForm(number, "яблоко", "яблока", "яблок"));
            Console.WriteLine(GetPluralForm(number, "студент", "студента", "студентов"));
            Console.WriteLine(GetPluralForm(number, "книга", "книги", "книг"));
            Console.WriteLine(GetPluralForm(number, "сообщение", "сообщения", "сообщений"));
            Console.WriteLine(GetPluralForm(number, "пользователь", "пользователя", "пользователей"));

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }

        private static string GetPluralForm(int number, string form1, string form2, string form3)
        {
            int lastDigit = number % 10;
            int lastTwoDigits = number % 100;

            if (lastTwoDigits >= 11 && lastTwoDigits <= 14)
            {
                return number + " " + form3;
            }

            if (lastDigit == 1)
            {
                return number + " " + form1;
            }

            if (lastDigit >= 2 && lastDigit <= 4)
            {
                return number + " " + form2;
            }

            return number + " " + form3;
        }
    }
}