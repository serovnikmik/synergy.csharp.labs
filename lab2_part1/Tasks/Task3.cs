using System;

namespace lab2Serov.Tasks
{
    public static class Task3
    {
        public static void Run()
        {
            Console.Title = "Задача 3: Разделить на максимальный";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 3: Разделить элементы на максимальный");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int[] array = ArrayGenerator.Generate1DArray(8, 1, 100);
            Console.WriteLine("Исходный массив:");
            Console.WriteLine(ArrayGenerator.ArrayToString(array));

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Максимальный элемент: " + max);
            Console.WriteLine();
            Console.WriteLine("Результат деления:");

            double[] result = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = (double)array[i] / max;
                Console.WriteLine("array[" + i + "] / " + max + " = " + result[i].ToString("F2"));
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}