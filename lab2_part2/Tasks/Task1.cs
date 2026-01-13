using System;

namespace lab2Serov.Part2.Tasks
{
    public static class Task1
    {
        public static void Run()
        {
            Console.Title = "Задача 1: Нечетное число";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 1: Вывести нечетное число");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int number = lab2Serov.ExtendedGenerator.GenerateOddNumber(1, 100);

            Console.WriteLine("Сгенерированное нечетное число: " + number);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}