using System;

namespace lab3Serov.Tasks
{
    public static class Task10
    {
        public static void Run()
        {
            Console.Title = "Задача 10: Форматированный вывод вещественных";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 10: Форматированный вывод вещественных");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Random random = new Random();
            double number1 = random.NextDouble() * 1000;
            double number2 = random.NextDouble() * 100;
            double number3 = random.NextDouble();

            Console.WriteLine("Исходные числа:");
            Console.WriteLine("number1 = " + number1);
            Console.WriteLine("number2 = " + number2);
            Console.WriteLine("number3 = " + number3);

            Console.WriteLine();
            Console.WriteLine("Форматированный вывод:");
            Console.WriteLine("F2: " + number1.ToString("F2") + ", " + number2.ToString("F2") + ", " + number3.ToString("F2"));
            Console.WriteLine("F4: " + number1.ToString("F4") + ", " + number2.ToString("F4") + ", " + number3.ToString("F4"));
            Console.WriteLine("E2: " + number1.ToString("E2") + ", " + number2.ToString("E2") + ", " + number3.ToString("E2"));
            Console.WriteLine("N: " + number1.ToString("N") + ", " + number2.ToString("N") + ", " + number3.ToString("N"));

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}