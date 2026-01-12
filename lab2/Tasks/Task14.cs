using System;

namespace lab2Serov.Tasks
{
    public static class Task14
    {
        public static void Run()
        {
            Console.Title = "Задача 14: Элементы > среднего";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 14: Элементы > среднего");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int[] array = ArrayGenerator.Generate1DArray(8, 1, 50);
            Console.WriteLine("Исходный массив:");
            Console.WriteLine(ArrayGenerator.ArrayToString(array));

            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double average = sum / array.Length;

            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое: " + average.ToString("F2"));
            Console.WriteLine();
            Console.WriteLine("Элементы, большие среднего:");

            bool found = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > average)
                {
                    Console.WriteLine("array[" + i + "] = " + array[i]);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Таких элементов нет");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}