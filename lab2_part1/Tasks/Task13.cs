using System;

namespace lab2Serov.Tasks
{
    public static class Task13
    {
        public static void Run()
        {
            Console.Title = "Задача 13: Минимальный с нечетными индексами";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 13: Минимальный с нечетными индексами");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int[] array = ArrayGenerator.Generate1DArray(10, 0, 100);
            Console.WriteLine("Исходный массив:");
            Console.WriteLine(ArrayGenerator.ArrayToString(array));

            int min = int.MaxValue;
            int minIndex = -1;

            for (int i = 1; i < array.Length; i += 2)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }

            Console.WriteLine();
            if (minIndex != -1)
            {
                Console.WriteLine("Минимальный элемент с нечетным индексом:");
                Console.WriteLine("array[" + minIndex + "] = " + min);
            }
            else
            {
                Console.WriteLine("Нет элементов с нечетными индексами");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}