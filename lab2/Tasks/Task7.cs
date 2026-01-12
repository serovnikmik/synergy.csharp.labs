using System;

namespace lab2Serov.Tasks
{
    public static class Task7
    {
        public static void Run()
        {
            Console.Title = "Задача 7: Противоположные элементы";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 7: Заменить элементы на противоположные");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int[] array = ArrayGenerator.Generate1DArray(8, -10, 10);
            Console.WriteLine("Исходный массив:");
            Console.WriteLine(ArrayGenerator.ArrayToString(array));

            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = -array[i];
            }

            Console.WriteLine();
            Console.WriteLine("Массив с противоположными элементами:");
            Console.WriteLine(ArrayGenerator.ArrayToString(result));

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}