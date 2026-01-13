using System;

namespace lab3Serov.Part2.Tasks
{
    public static class Task14
    {
        public static void Run()
        {
            Console.Title = "Задача 14: Копирование части строки";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 14: Копирование части строки");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            string text = "Программирование";
            int startIndex = 4;
            int length = 6;

            Console.WriteLine("Исходная строка: " + text);
            Console.WriteLine("Начальный индекс: " + startIndex);
            Console.WriteLine("Длина: " + length);

            if (startIndex >= 0 && startIndex + length <= text.Length)
            {
                string substring = text.Substring(startIndex, length);
                Console.WriteLine();
                Console.WriteLine("Скопированная часть: " + substring);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: некорректные параметры!");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}