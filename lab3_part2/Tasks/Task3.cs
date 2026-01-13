using System;

namespace lab3Serov.Part2.Tasks
{
    public static class Task3
    {
        public static void Run()
        {
            Console.Title = "Задача 3: Проверка кратности";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 3: Проверка кратности числа");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Console.Write("Введите число: ");
            string input1 = Console.ReadLine();
            Console.Write("Введите делитель: ");
            string input2 = Console.ReadLine();

            if (!int.TryParse(input1, out int number) || !int.TryParse(input2, out int divisor) || divisor == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка ввода!");
                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата...");
                Console.ReadKey();
                return;
            }

            bool isMultiple = number % divisor == 0;

            Console.WriteLine();
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
                Console.WriteLine("Остаток: " + (number % divisor));
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}