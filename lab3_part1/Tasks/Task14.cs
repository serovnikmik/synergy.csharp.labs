using System;

namespace lab3Serov.Tasks
{
    public static class Task14
    {
        public static void Run()
        {
            Console.Title = "Задача 14: Проверка кратности";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 14: Проверка кратности числа");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int number = MathHelper.GenerateNumber(1, 100);
            int divisor = MathHelper.GenerateNumber(2, 10);

            bool isMultiple = number % divisor == 0;

            Console.WriteLine("Число: " + number);
            Console.WriteLine("Делитель: " + divisor);
            Console.WriteLine();

            if (isMultiple)
            {
                Console.WriteLine(number + " кратно " + divisor);
            }
            else
            {
                Console.WriteLine(number + " не кратно " + divisor);
                Console.WriteLine("Остаток от деления: " + (number % divisor));
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}