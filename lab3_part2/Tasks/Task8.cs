using System;
using System.Text;

namespace lab3Serov.Part2.Tasks
{
    public static class Task8
    {
        public static void Run()
        {
            Console.Title = "Задача 8: Удаление одинаковых символов";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 8: Удаление одинаковых символов");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            string text = "программирование";

            Console.WriteLine("Исходная строка: " + text);

            StringBuilder result = new StringBuilder();
            foreach (char c in text)
            {
                if (result.ToString().IndexOf(c) == -1)
                {
                    result.Append(c);
                }
            }

            Console.WriteLine("Результат: " + result.ToString());

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}