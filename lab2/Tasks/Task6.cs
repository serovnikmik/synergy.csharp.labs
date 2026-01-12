using System;

namespace lab2Serov.Tasks
{
    public static class Task6
    {
        public static void Run()
        {
            Console.Title = "Задача 6: Четные/нечетные символы";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 6: Четные/нечетные символы строки");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            string[] words = { "программирование", "компьютер", "алгоритм", "структура", "массив" };
            int index = ArrayGenerator.GenerateNumber(0, words.Length - 1);
            string word = words[index];

            Console.WriteLine("Исходное слово: " + word);

            string evenChars = "";
            string oddChars = "";

            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evenChars += word[i];
                }
                else
                {
                    oddChars += word[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Символы на четных позициях: " + evenChars);
            Console.WriteLine("Символы на нечетных позициях: " + oddChars);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}