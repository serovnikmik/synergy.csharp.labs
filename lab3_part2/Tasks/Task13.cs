using System;

namespace lab3Serov.Part2.Tasks
{
    public static class Task13
    {
        public static void Run()
        {
            Console.Title = "Задача 13: Удаление подстроки";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 13: Удаление подстроки");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            string text = "Программирование на C# это интересно";
            string substring = "на C# ";

            Console.WriteLine("Исходная строка: " + text);
            Console.WriteLine("Подстрока для удаления: " + substring);

            string result = text.Replace(substring, "");

            Console.WriteLine();
            Console.WriteLine("Результат: " + result);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}