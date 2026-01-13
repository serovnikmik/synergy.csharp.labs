using System;

namespace lab3Serov.Part2.Tasks
{
    public static class Task15
    {
        public static void Run()
        {
            Console.Title = "Задача 15: Длина строки";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 15: Определение длины строки");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Console.Write("Введите строку: ");
            string text = Console.ReadLine();

            if (string.IsNullOrEmpty(text))
            {
                text = "Пример строки для тестирования";
            }

            int length = text.Length;

            Console.WriteLine();
            Console.WriteLine("Строка: " + text);
            Console.WriteLine("Длина строки: " + length + " символов");
            Console.WriteLine("Длина без пробелов: " + text.Replace(" ", "").Length + " символов");

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}