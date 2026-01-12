using System;

namespace Lab1Serov.Tasks
{
    public static class Task2
    {
        public static void Run()
        {
            Console.Title = "Задача 2: Имя и возраст";
            Console.Clear();

            Console.WriteLine("========================================");
            Console.WriteLine("ЗАДАЧА 2: Имя и возраст пользователя");
            Console.WriteLine("========================================\n");

            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            string input = Console.ReadLine();

            int age;
            if (int.TryParse(input, out age))
            {
                Console.WriteLine("\n----------------------------------------");
                Console.WriteLine("РЕЗУЛЬТАТ:");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Имя: {name}");
                Console.WriteLine($"Возраст: {age} лет");
            }
            else
            {
                Console.WriteLine("\nОшибка: возраст должен быть числом!");
            }

            Console.WriteLine("\n[Нажмите любую клавишу для возврата...]");
            Console.ReadKey();
        }
    }
}