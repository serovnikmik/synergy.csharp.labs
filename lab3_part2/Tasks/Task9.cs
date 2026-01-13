using System;

namespace lab3Serov.Part2.Tasks
{
    public static class Task9
    {
        public static void Run()
        {
            Console.Title = "Задача 9: Вывод строки по диагонали";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 9: Вывод строки по диагонали");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            string text = "Диагональ";

            Console.WriteLine("Строка: " + text);
            Console.WriteLine();
            Console.WriteLine("Вывод по диагонали:");

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(text[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}