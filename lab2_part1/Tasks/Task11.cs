using System;

namespace lab2Serov.Tasks
{
    public static class Task11
    {
        public static void Run()
        {
            Console.Title = "Задача 11: Разность max и min";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 11: Разность max и min элементов");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int[] array = ArrayGenerator.Generate1DArray(10, -50, 50);
            Console.WriteLine("Исходный массив:");
            Console.WriteLine(ArrayGenerator.ArrayToString(array));

            int max = array[0];
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
            }

            int difference = max - min;

            Console.WriteLine();
            Console.WriteLine("Максимальный элемент: " + max);
            Console.WriteLine("Минимальный элемент: " + min);
            Console.WriteLine("Разность (max - min): " + difference);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}