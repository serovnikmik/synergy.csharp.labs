using System;

namespace lab2Serov.Part2.Tasks
{
    public static class Task3
    {
        public static void Run()
        {
            Console.Title = "Задача 3: Двухзначные числа";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 3: Двухзначные числа с суммой цифр кратной 2");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int[] numbers = new int[20];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = lab2Serov.ExtendedGenerator.GenerateTwoDigitNumber();
            }

            Console.WriteLine("Сгенерированные числа:");
            Console.WriteLine(string.Join(" ", numbers));

            Console.WriteLine();
            Console.WriteLine("Числа, где сумма цифр кратна 2:");

            int count = 0;
            foreach (int number in numbers)
            {
                int tens = number / 10;
                int units = number % 10;
                int sum = tens + units;

                if (sum % 2 == 0)
                {
                    Console.WriteLine(number + " (сумма цифр: " + sum + ")");
                    count++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Всего таких чисел: " + count);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}