using System;

namespace lab2Serov.Part2.Tasks
{
    public static class Task15
    {
        public static void Run()
        {
            Console.Title = "Задача 15: Индексы элементов в пределах";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 15: Индексы элементов в пределах");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int[] array = lab2Serov.ArrayGenerator.Generate1DArray(15, -20, 20);
            Console.WriteLine("Исходный массив:");
            Console.WriteLine(lab2Serov.ArrayGenerator.ArrayToString(array));

            Random random = new Random();
            int lowerBound = random.Next(-15, 0);
            int upperBound = random.Next(0, 16);

            Console.WriteLine();
            Console.WriteLine("Предел: от " + lowerBound + " до " + upperBound);
            Console.WriteLine();
            Console.WriteLine("Индексы элементов в пределах:");

            bool found = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= lowerBound && array[i] <= upperBound)
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