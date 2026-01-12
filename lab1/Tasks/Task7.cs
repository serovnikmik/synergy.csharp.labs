using System;

namespace Lab1Serov.Tasks
{
    public static class Task7
    {
        public static void Run()
        {
            Console.Title = "Задача 7: Год рождения по возрасту";
            Console.Clear();

            Console.WriteLine("========================================");
            Console.WriteLine("ЗАДАЧА 7: Год рождения по возрасту");
            Console.WriteLine("========================================");
            Console.WriteLine();

            Console.Write("Введите ваш возраст: ");
            string input = Console.ReadLine();

            bool isNumber = int.TryParse(input, out int age);
            if (!isNumber)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: возраст должен быть числом!");
                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата...");
                Console.ReadKey();
                return;
            }

            if (age < 0)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: возраст не может быть отрицательным!");
                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата...");
                Console.ReadKey();
                return;
            }

            if (age > 150)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: возраст не может быть больше 150 лет!");
                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата...");
                Console.ReadKey();
                return;
            }

            int currentYear = DateTime.Now.Year;
            int birthYear = currentYear - age;

            Console.WriteLine();

            Console.WriteLine("Возраст: " + age + " лет");
            Console.WriteLine("Текущий год: " + currentYear);
            Console.WriteLine("Ваш год рождения: " + birthYear);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}