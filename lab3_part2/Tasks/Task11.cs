using System;

namespace lab3Serov.Part2.Tasks
{
    public static class Task11
    {
        public static void Run()
        {
            Console.Title = "Задача 11: Переворот строки";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 11: Переворот строки");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Console.Write("Введите строку: ");
            string text = Console.ReadLine();

            if (string.IsNullOrEmpty(text))
            {
                text = "Пример строки";
            }

            Console.WriteLine();
            Console.WriteLine("Исходная строка: " + text);

            char[] chars = text.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);

            Console.WriteLine("Перевернутая строка: " + reversed);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}