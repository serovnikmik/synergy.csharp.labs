using System;

namespace lab2Serov.Part2.Tasks
{
    public static class Task9
    {
        public static void Run()
        {
            Console.Title = "Задача 9: Замена минимального";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 9: Среднее отрицательных, замена минимального");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int[] array = lab2Serov.ArrayGenerator.Generate1DArray(10, -20, 10);
            Console.WriteLine("Исходный массив:");
            Console.WriteLine(lab2Serov.ArrayGenerator.ArrayToString(array));

            double negativeSum = 0;
            int negativeCount = 0;
            int minIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negativeSum += array[i];
                    negativeCount++;
                }

                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }

            Console.WriteLine();
            if (negativeCount > 0)
            {
                double negativeAverage = negativeSum / negativeCount;
                Console.WriteLine("Среднее арифметическое отрицательных: " + negativeAverage.ToString("F2"));
                Console.WriteLine("Минимальный элемент: array[" + minIndex + "] = " + array[minIndex]);

                array[minIndex] = (int)Math.Round(negativeAverage);

                Console.WriteLine();
                Console.WriteLine("Массив после замены:");
                Console.WriteLine(lab2Serov.ArrayGenerator.ArrayToString(array));
            }
            else
            {
                Console.WriteLine("В массиве нет отрицательных элементов");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}