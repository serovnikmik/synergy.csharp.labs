using System;

namespace Lab1Serov.Tasks
{
    public static class Task6
    {
        public static void Run()
        {
            Console.Title = "Задача 6: Имя и возраст";
            Console.Clear();

            Console.WriteLine("========================================");
            Console.WriteLine("ЗАДАЧА 6: Имя и возраст по году рождения");
            Console.WriteLine("========================================");
            Console.WriteLine();

            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: имя не может быть пустым!");
                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Диапазон корректных годов: 1900 - 2026");
            Console.Write("Введите год рождения: ");
            string yearInput = Console.ReadLine();

            int currentYear = DateTime.Now.Year;
            int minYear = 1900;
            int maxYear = 2026;

            bool isNumber = int.TryParse(yearInput, out int birthYear);
            if (!isNumber)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: год должен быть числом!");
                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата...");
                Console.ReadKey();
                return;
            }

            if (birthYear < minYear)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: год не может быть меньше " + minYear + "!");
                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата...");
                Console.ReadKey();
                return;
            }

            if (birthYear > maxYear)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: год не может быть больше " + maxYear + "!");
                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата...");
                Console.ReadKey();
                return;
            }

            int age = currentYear - birthYear;

            if (age < 0)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: вы еще не родились!");
                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("РЕЗУЛЬТАТ:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Имя пользователя: " + name);
            Console.WriteLine("Год рождения: " + birthYear);
            Console.WriteLine("Текущий год: " + currentYear);
            Console.WriteLine("Возраст: " + age + " лет");

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}