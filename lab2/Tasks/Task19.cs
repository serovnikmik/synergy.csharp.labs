using System;

namespace lab2Serov.Tasks
{
    public static class Task19
    {
        public static void Run()
        {
            Console.Title = "Задача 19: Трехзначное число, кончается на 0";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 19: Трехзначное число, кончается на 0");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int number = ArrayGenerator.GenerateThreeDigitEndingWithZero();

            Console.WriteLine("Сгенерированное число: " + number);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}