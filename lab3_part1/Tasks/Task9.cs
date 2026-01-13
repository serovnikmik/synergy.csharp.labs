using System;

namespace lab3Serov.Tasks
{
    public static class Task9
    {
        public static void Run()
        {
            Console.Title = "Задача 9: Простой ввод-вывод";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 9: Простейший ввод и вывод");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            string ageInput = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Результат:");
            Console.WriteLine("Привет, " + name + "!");
            Console.WriteLine("Тебе " + ageInput + " лет.");

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}