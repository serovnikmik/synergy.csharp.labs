using System;

namespace Lab1Serov.Tasks
{
    public static class Task9
    {
        public static void Run()
        {
            Console.Title = "Задача 9: Последовательность чисел";
            Console.Clear();

            Console.WriteLine("========================================");
            Console.WriteLine("ЗАДАЧА 9: Последовательность чисел");
            Console.WriteLine("========================================");
            Console.WriteLine();

            Console.Write("Введите число: ");
            string input = Console.ReadLine();

            bool isNumber = double.TryParse(input, out double number);

            if (!isNumber)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: нужно ввести число!");
                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата...");
                Console.ReadKey();
                return;
            }

            double previous = number - 1;
            double next = number + 1;

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("РЕЗУЛЬТАТ:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Число на единицу меньше: " + previous);
            Console.WriteLine("Введенное число: " + number);
            Console.WriteLine("Число на единицу больше: " + next);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}