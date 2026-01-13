using System;

namespace lab3Serov.Part2.Tasks
{
    public static class Task4
    {
        public static void Run()
        {
            Console.Title = "Задача 4: Извлечение цифр";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 4: Извлечение цифр числа");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Console.Write("Введите число: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: нужно ввести число!");
                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Исходное число: " + number);
            Console.WriteLine("Цифры числа (справа налево):");

            int temp = Math.Abs(number);
            while (temp > 0)
            {
                int digit = temp % 10;
                Console.WriteLine(digit);
                temp /= 10;
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}