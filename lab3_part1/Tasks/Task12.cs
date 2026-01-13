using System;

namespace lab3Serov.Tasks
{
    public static class Task12
    {
        public static void Run()
        {
            Console.Title = "Задача 12: Простые числа";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 12: Количество простых чисел");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int[] numbers = MathHelper.GenerateArray(20, 1, 100);
            Console.WriteLine("Массив чисел:");
            Console.WriteLine(MathHelper.ArrayToString(numbers));

            int primeCount = 0;

            Console.WriteLine();
            Console.WriteLine("Простые числа в массиве:");

            foreach (int number in numbers)
            {
                if (MathHelper.IsPrime(number))
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