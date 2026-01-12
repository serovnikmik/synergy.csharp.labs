using System;

namespace lab2Serov.Tasks
{
    public static class Task12
    {
        public static void Run()
        {
            Console.Title = "Задача 12: Сумма четных отрицательных";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 12: Сумма четных отрицательных");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int[] array = ArrayGenerator.Generate1DArray(12, -30, 20);
            Console.WriteLine("Исходный массив:");
            Console.WriteLine(ArrayGenerator.ArrayToString(array));

            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 && array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Сумма четных отрицательных элементов: " + sum);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}