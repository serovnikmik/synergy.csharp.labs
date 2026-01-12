using System;

namespace lab2Serov.Tasks
{
    public static class Task4
    {
        public static void Run()
        {
            Console.Title = "Задача 4: Первый положительный";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 4: Первый положительный элемент");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int[] array = ArrayGenerator.Generate1DArray(12, -20, 10);
            Console.WriteLine("Исходный массив:");
            Console.WriteLine(ArrayGenerator.ArrayToString(array));

            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    index = i;
                    break;
                }
            }

            Console.WriteLine();
            if (index != -1)
            {
                Console.WriteLine("Первый положительный элемент:");
                Console.WriteLine("array[" + index + "] = " + array[index]);
            }
            else
            {
                Console.WriteLine("В массиве нет положительных элементов");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}