using System;

namespace Lab1Serov.Tasks
{
    public static class Task5
    {
        public static void Run()
        {
            Console.Title = "Задача 5: Возраст по году рождения";
            Console.Clear();

            Console.WriteLine("========================================");
            Console.WriteLine("ЗАДАЧА 5: Возраст по году рождения");
            Console.WriteLine("========================================");
            Console.WriteLine();
            Console.WriteLine("Диапазон корректных годов: 1900 - 2026");
            Console.WriteLine();

            Console.Write("Введите год рождения: ");
            string input = Console.ReadLine();

            int currentYear = DateTime.Now.Year;
            int minYear = 1900;
            int maxYear = 2026;

            bool isNumber = int.TryParse(input, out int birthYear);

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

            Console.WriteLine("Год рождения: " + birthYear);
            Console.WriteLine("Текущий год: " + currentYear);
            Console.WriteLine("Ваш возраст: " + age + " лет");

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}