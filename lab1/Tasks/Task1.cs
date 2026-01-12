using System;

namespace Lab1Serov.Tasks
{
    public static class Task1
    {
        public static void Run()
        {
            Console.Title = "Задача 1: Имя и фамилия";
            Console.Clear();

            Console.WriteLine("========================================");
            Console.WriteLine("ЗАДАЧА 1: Имя и фамилия пользователя");
            Console.WriteLine("========================================\n");

            // Ввод данных
            Console.Write("Введите имя: ");
            string firstName = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("РЕЗУЛЬТАТ:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Имя: {firstName}");
            Console.WriteLine($"Фамилия: {lastName}");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("\n[Нажмите любую клавишу для возврата...]");
            Console.ReadKey();
        }
    }
}