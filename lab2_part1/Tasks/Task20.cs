using System;

namespace lab2Serov.Tasks
{
    public static class Task20
    {
        public static void Run()
        {
            Console.Title = "Задача 20: Количество положительных";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 20: Количество положительных элементов");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int[] array = ArrayGenerator.Generate1DArray(12, -15, 15);
            Console.WriteLine("Исходный массив:");
            Console.WriteLine(ArrayGenerator.ArrayToString(array));

            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    count++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Количество положительных элементов: " + count);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}