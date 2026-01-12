using System;

namespace lab2Serov.Tasks
{
    public static class Task16
    {
        public static void Run()
        {
            Console.Title = "Задача 16: Сумма положительных";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 16: Сумма положительных элементов");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int[] array = ArrayGenerator.Generate1DArray(10, -20, 20);
            Console.WriteLine("Исходный массив:");
            Console.WriteLine(ArrayGenerator.ArrayToString(array));

            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Сумма положительных элементов: " + sum);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}