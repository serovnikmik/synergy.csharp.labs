using System;

namespace lab3Serov.Part2.Tasks
{
    public static class Task12
    {
        public static void Run()
        {
            Console.Title = "Задача 12: Вставка подстроки";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 12: Вставка подстроки");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            string text = "Привет мир";
            string substring = "дорогой ";
            int position = 7;

            Console.WriteLine("Исходная строка: " + text);
            Console.WriteLine("Подстрока для вставки: " + substring);
            Console.WriteLine("Позиция для вставки: " + position);

            string result = text.Insert(position, substring);

            Console.WriteLine();
            Console.WriteLine("Результат: " + result);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}