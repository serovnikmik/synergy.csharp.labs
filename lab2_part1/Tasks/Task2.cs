using System;

namespace lab2Serov.Tasks
{
    public static class Task2
    {
        public static void Run()
        {
            Console.Title = "Задача 2: Элементы > предыдущего";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 2: Элементы массива > предыдущего");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int[] array = ArrayGenerator.Generate1DArray(10, -50, 50);
            Console.WriteLine("Исходный массив:");
            Console.WriteLine(ArrayGenerator.ArrayToString(array));

            Console.WriteLine();
            Console.WriteLine("Элементы, большие предыдущего:");

            bool found = false;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
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