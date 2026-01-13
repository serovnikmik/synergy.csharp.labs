using System;

namespace lab3Serov.Part2.Tasks
{
    public static class Task10
    {
        public static void Run()
        {
            Console.Title = "Задача 10: Частота символа";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 10: Частота встречаемости символа");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            string text = "программирование";
            char target = 'р';

            Console.WriteLine("Строка: " + text);
            Console.WriteLine("Искомый символ: '" + target + "'");

            int count = 0;
            foreach (char c in text)
            {
                if (c == target)
                {
                    count++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Символ '" + target + "' встречается " + count + " раз");

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}