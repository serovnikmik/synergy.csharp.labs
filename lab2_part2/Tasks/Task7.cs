using System;

namespace lab2Serov.Part2.Tasks
{
    public static class Task7
    {
        public static void Run()
        {
            Console.Title = "Задача 7: Массив B из положительных A";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 7: Массив B из положительных элементов A");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int[] arrayA = lab2Serov.ArrayGenerator.Generate1DArray(15, -20, 20);
            Console.WriteLine("Исходный массив A:");
            Console.WriteLine(lab2Serov.ArrayGenerator.ArrayToString(arrayA));

            int count = 0;
            for (int i = 0; i < arrayA.Length; i += 2)
            {
                if (arrayA[i] > 0)
                {
                    count++;
                }
            }

            int[] arrayB = new int[count];
            int index = 0;

            for (int i = 0; i < arrayA.Length; i += 2)
            {
                if (arrayA[i] > 0)
                {
                    arrayB[index] = arrayA[i];
                    index++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Массив B (положительные элементы с четными индексами):");

            if (arrayB.Length > 0)
            {
                Console.WriteLine(lab2Serov.ArrayGenerator.ArrayToString(arrayB));
            }
            else
            {
                Console.WriteLine("Нет положительных элементов с четными индексами");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}