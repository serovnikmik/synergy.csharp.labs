using System;

namespace lab2Serov.Part2.Tasks
{
    public static class Task17
    {
        public static void Run()
        {
            Console.Title = "Задача 17: Четные и нечетные цифры";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 17: Четные и нечетные цифры числа");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int number = lab2Serov.ExtendedGenerator.GenerateNumber(10000, 99999);

            Console.WriteLine("Исходное число: " + number);

            int evenCount = 0;
            int oddCount = 0;
            int temp = Math.Abs(number);

            Console.WriteLine();
            Console.WriteLine("Анализ цифр:");

            while (temp > 0)
            {
                int digit = temp % 10;

                if (digit % 2 == 0)
                {
                    Console.WriteLine("Цифра " + digit + " - четная");
                    evenCount++;
                }
                else
                {
                    Console.WriteLine("Цифра " + digit + " - нечетная");
                    oddCount++;
                }

                temp /= 10;
            }

            Console.WriteLine();
            Console.WriteLine("Итог:");
            Console.WriteLine("Четных цифр: " + evenCount);
            Console.WriteLine("Нечетных цифр: " + oddCount);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}