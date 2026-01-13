using System;

namespace lab2Serov.Tasks
{
    public static class Task10
    {
        public static void Run()
        {
            Console.Title = "Задача 10: Поменять min и max";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 10: Поменять min и max элементы");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int[] array = ArrayGenerator.Generate1DArray(10, -20, 20);
            Console.WriteLine("Исходный массив:");
            Console.WriteLine(ArrayGenerator.ArrayToString(array));

            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Минимальный элемент: array[" + minIndex + "] = " + array[minIndex]);
            Console.WriteLine("Максимальный элемент: array[" + maxIndex + "] = " + array[maxIndex]);

            int temp = array[minIndex];
            array[minIndex] = array[maxIndex];
            array[maxIndex] = temp;

            Console.WriteLine();
            Console.WriteLine("Массив после замены:");
            Console.WriteLine(ArrayGenerator.ArrayToString(array));

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}