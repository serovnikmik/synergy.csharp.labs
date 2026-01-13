using System;

namespace lab3Serov.Part2.Tasks
{
    public static class Task1
    {
        public static void Run()
        {
            Console.Title = "Задача 1: Простые числа";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 1: Количество простых чисел");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int[] numbers = StringArrayHelper.GenerateArray(20, 1, 100);
            Console.WriteLine("Массив чисел:");
            Console.WriteLine(StringArrayHelper.ArrayToString(numbers));

            int primeCount = 0;
            Console.WriteLine();
            Console.WriteLine("Простые числа в массиве:");

            foreach (int number in numbers)
            {
                if (StringArrayHelper.IsPrime(number))
                {
                    Console.Write(number + " ");
                    primeCount++;
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Всего простых чисел: " + primeCount);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}